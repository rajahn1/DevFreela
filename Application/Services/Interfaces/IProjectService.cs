using Application.InputModels;
using Application.ViewModels;
using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IProjectService
{
    List<ProjectViewModel> GetAllProjects(string query);
    ProjectDetailsViewModel GetProjectById(int id);
    int Create(NewProjectInputModel model);
    void Update(UpdateProjectInputModel model);
    void CreateComment(CreateCommentInputModel model);
    void Start(int id);
    void Finish(int id); 
    void Delete(int id);
}