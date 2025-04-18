namespace Application.ViewModels.User;

public class UserDetailsViewModel(int id, string fullname, string email, DateTime birthdate)
{
    public int Id { get; set; } = id;
    public string Fullname { get; set; } = fullname;
    public string Email { get; set; } = email;
    public DateTime Birthdate { get; set; } = birthdate;
}