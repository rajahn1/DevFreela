namespace Domain.Entities;

public class ProjectComment(string content, int idProject, int idUser) : BaseEntity
{
    public int IdProject  { get; set; } =  idProject;
    public int IdUser { get; set; } = idUser;
    public string Content { get; set; } = content;
}