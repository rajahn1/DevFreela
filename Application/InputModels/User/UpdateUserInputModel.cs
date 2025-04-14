namespace Application.InputModels.User;

public class UpdateUserInputModel(int id, string fullname, bool active)
{
    public int Id { get; set; } = id;
    public string Fullname { get; set; } = fullname;
    public bool Active { get; set; } = active;
}