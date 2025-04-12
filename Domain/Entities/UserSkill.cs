using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class UserSkill(int idUser, int idSkill): BaseEntity
{
    [ForeignKey("IdUser")]
    public int IdUser { get; set; } = idUser;
    [ForeignKey("IdSkill")]
    public int IdSkill { get; set; } = idSkill;
    public Skill Skill { get; set; }
}