using Application.InputModels.User;
using Application.Services.Interfaces;
using Application.ViewModels.User;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Persistence;

namespace Application.Services.Implementations;

public class UserService(DevFreelaDbContext dbContext) : IUserService
{
    public List<UserViewModel> GetAll()
    {
        var users = dbContext.Users;
        return users.Select(u => new UserViewModel(u.Id, u.FullName, u.Email)).ToList();
    }

    public UserDetailsViewModel GetUserById(int id)
    {
        var user = dbContext.Users.FirstOrDefault(u => u.Id == id);
        if (user == null) throw new KeyNotFoundException();
        return new UserDetailsViewModel(user.Id, user.FullName, user.Email,user.BirthDate);
    }

    public void Delete(int id)
    {
        var user = dbContext.Users.FirstOrDefault(u => u.Id == id);
        if (user == null) throw new KeyNotFoundException();
        dbContext.Users.Remove(user);
        dbContext.SaveChanges();
    }

    public int Create(NewUserInputModel model)
    {
        User user = new(model.Fullname, model.Email,model.Birthdate);
        dbContext.Users.Add(user);
        dbContext.SaveChanges();
        return user.Id;
    }

    public void Update(UpdateUserInputModel model)
    {
        var user = dbContext.Users.FirstOrDefault(u => u.Id == model.Id);
        if (user == null) throw new KeyNotFoundException();
        user.Update(model.Fullname, model.Active);
        dbContext.Update(user);
    }
}