using Application.InputModels.User;
using Application.Services.Interfaces;
using Application.ViewModels.User;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Persistence;

namespace Application.Services.Implementations;

public class UserService(DevFreelaDbContext dbContext) : IUserService
{
    private readonly DevFreelaDbContext _dbContext = dbContext;
    public List<UserViewModel> GetAll()
    {
        var users = _dbContext.Users;
        return users.Select(u => new UserViewModel(u.Id, u.FullName, u.Email)).ToList();
    }

    public UserDetailsViewModel GetUserById(int id)
    {
        var user = _dbContext.Users.FirstOrDefault(u => u.Id == id);
        if (user == null) throw new KeyNotFoundException();
        return new UserDetailsViewModel(user.Id, user.FullName, user.Email,user.BirthDate);
    }

    public void Delete(int id)
    {
        var user = _dbContext.Users.FirstOrDefault(u => u.Id == id);
        if (user == null) throw new KeyNotFoundException();
        dbContext.Users.Remove(user);
    }

    public int Create(NewUserInputModel model)
    {
        User user = new(model.Fullname, model.Email,model.Birthdate);
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
        return user.Id;
    }

    public void Update(UpdateUserInputModel model)
    {
        var user = _dbContext.Users.FirstOrDefault(u => u.Id == model.Id);
        if (user == null) throw new KeyNotFoundException();
        user.Update(model.Fullname, model.Active);
        dbContext.Update(user);
    }
}