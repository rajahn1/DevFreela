using Application.InputModels;
using Application.Services.Interfaces;
using Application.ViewModels;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Application.Services.Implementations;

public class ProjectService(DevFreelaDbContext dbContext): IProjectService
{
    public List<ProjectViewModel> GetAllProjects(string query)
    {
        var projects = dbContext.Projects;
        var projectsViewModel = projects.Select(p => new ProjectViewModel(p.Id, p.Title, p.CreatedAt)).ToList();
        return projectsViewModel;
    }

    public ProjectDetailsViewModel GetProjectById(int id)
    { 
        // include: you can return the properties of a relationated entity
        var project = dbContext.Projects
            .Include(p => p.Client)
            .Include(p => p.Freelancer)
            .FirstOrDefault(p => p.Id == id);
        if (project == null) return null;
        var projectViewModel = new ProjectDetailsViewModel(
            project.Id, 
            project.Description,
            project.TotalCost,
            project.StartedAt.GetValueOrDefault(),
            project.Title,
            project.FinishedAt.GetValueOrDefault(),
            project.Freelancer.FullName,
            project.Client.FullName
        );
        
        return projectViewModel;
    }

    public int Create(NewProjectInputModel model)
    {
        Project project = new (model.Title,model.Description, model.TotalCost, model.IdClient, model.IdFreelancer);
            
        dbContext.Projects.Add(project);
        dbContext.SaveChanges();
        
        return project.Id;
    }

    public void Update(UpdateProjectInputModel model)
    {
        var project = dbContext.Projects.FirstOrDefault(p => p.Id == model.Id);
        project.Update(model.Title, model.Description, model.TotalCost, model.Id);
        dbContext.Update(project);
        dbContext.SaveChanges();
    }

    public void CreateComment(CreateCommentInputModel model)
    {
        ProjectComment comment = new(model.Content, model.IdUser, model.IdProject);
        dbContext.ProjectComments.Add(comment);
        dbContext.SaveChanges();
    }

    public void Start(int id)
    {
        var project = dbContext.Projects.FirstOrDefault(p => p.Id == id);
        project.Start();
        dbContext.SaveChanges();
    }

    public void Finish(int id)
    {
        var project = dbContext.Projects.FirstOrDefault(p => p.Id == id);
        project.Finish();
        dbContext.SaveChanges();
    }

    public void Delete(int id)
    {
        var project = dbContext.Projects.SingleOrDefault(p => p.Id == id);
        if (project != null) project.Cancel();
        dbContext.SaveChanges();
    }
}