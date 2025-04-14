namespace Application.InputModels.User;

public class NewUserInputModel(string fullname, string email, DateTime birthdate)
{
    public string Fullname { get; set; } = fullname;
    public string Email { get; set; } = email;
    public DateTime Birthdate { get; set; } = birthdate;
}