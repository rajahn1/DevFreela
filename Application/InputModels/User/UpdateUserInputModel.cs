namespace Application.InputModels.User;

public class UpdateUserInputModel
{
    public int Id { get; set; }
    public string Fullname { get; set; } 
    public bool Active { get; set; }
}