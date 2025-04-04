namespace Application.ViewModels.User;

public class UserViewModel(int id, string fullname, string email)
{
    public int Id { get; set; } = id;
    public string Fullname { get; set; } = fullname;
    public string Email { get; set; } = email;
}