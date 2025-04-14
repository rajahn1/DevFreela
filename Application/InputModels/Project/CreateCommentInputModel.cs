namespace Application.InputModels;

public class CreateCommentInputModel(string content, int idUser, int idProject)
{
    public required string Content { get; set; } = content;
    public int IdUser { get; set; } = idUser;
    public int IdProject { get; set; } = idProject;
}