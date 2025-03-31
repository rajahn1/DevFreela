using System.Diagnostics;
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
        throw new NotImplementedException();
    }

    public ProjectDetailsViewModel GetProjectById(int id)
    {
        throw new NotImplementedException();
    }

    public int Create(NewProjectInputModel model)
    {
        Project project = new (model.Title,model.Description, model.TotalCost, model.IdClient, model.IdFreelancer);
            
        _dbContext.Projects.Add(project);
        return 1;
    }

    public void Update(UpdateProjectInputModel model)
    {
        throw new NotImplementedException();
    }

    public void CreateComment(CreateCommentInputModel model)
    {
        throw new NotImplementedException();
    }

    public void Start(int id)
    {
        throw new NotImplementedException();
    }

    public void Finish(int id)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}