using System.Diagnostics;
using Application.InputModels.User;
using Application.ViewModels.User;
using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IUserService
{
    public List<UserViewModel> GetAll();
    public UserDetailsViewModel GetUserById(int id);
    public void Delete(int id);
    public int Create(NewUserInputModel model);
    public void Update(UpdateUserInputModel model);
    
}