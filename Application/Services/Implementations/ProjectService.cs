using Application.InputModels;
using Application.Services.Interfaces;
using Application.ViewModels;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Application.Services.Implementations;

public class ProjectService(DevFreelaDbContext dbContext): IProjectService
{
    private readonly DevFreelaDbContext _dbContext = dbContext;
    
    public List<ProjectViewModel> GetAllProjects(string query)
    {
        var projects = _dbContext.Projects;
        var projectsViewModel = projects.Select(p => new ProjectViewModel(p.Id, p.Title, p.CreatedAt)).ToList();
        return projectsViewModel;
    }

    public ProjectDetailsViewModel GetProjectById(int id)
    { 
        var project = _dbContext.Projects.FirstOrDefault(p => p.Id == id);
        if (project == null) return null;
        var projectViewModel = new ProjectDetailsViewModel(
            project.Id, 
            project.Description,
            project.TotalCost,
            project.StartedAt.GetValueOrDefault(),
            project.Title,
            project.FinishedAt.GetValueOrDefault()
        );
        
        return projectViewModel;
    }

    public int Create(NewProjectInputModel model)
    {
        Project project = new (model.Title,model.Description, model.TotalCost, model.IdClient, model.IdFreelancer);
            
        _dbContext.Projects.Add(project);
        
        return project.Id;
    }

    public void Update(UpdateProjectInputModel model)
    {
        var project = _dbContext.Projects.FirstOrDefault(p => p.Id == model.Id);
        project.Update(model.Title, model.Description, model.TotalCost, model.Id);
        _dbContext.Update(project);
    }

    public void CreateComment(CreateCommentInputModel model)
    {
        ProjectComment comment = new(model.Content, model.IdUser, model.IdProject);
        _dbContext.ProjectComments.Add(comment);
    }

    public void Start(int id)
    {
        var project = _dbContext.Projects.FirstOrDefault(p => p.Id == id);
        project.Start();
    }

    public void Finish(int id)
    {
        var project = _dbContext.Projects.FirstOrDefault(p => p.Id == id);
        project.Finish();
    }

    public void Delete(int id)
    {
        var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
        if (project != null) project.Cancel();
    }
}