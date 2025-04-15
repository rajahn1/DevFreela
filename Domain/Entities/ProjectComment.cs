using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class ProjectComment(string content, int idProject, int idUser) : BaseEntity
{
    public int IdProject  { get; set; } =  idProject;
    public int IdUser { get; set; } = idUser;
    public string Content { get; set; } = content;
    public Project Project { get; set; }
    public User User { get; set; }
}