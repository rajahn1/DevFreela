using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class ProjectComment(string content, int idProject, int idUser) : BaseEntity
{
    [ForeignKey("IdProject")]
    public int IdProject  { get; set; } =  idProject;
    [ForeignKey("IdUser")]
    public int IdUser { get; set; } = idUser;
    public string Content { get; set; } = content;
}