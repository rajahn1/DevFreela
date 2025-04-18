using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class UserSkill(int idUser, int idSkill): BaseEntity
{
    public int IdUser { get; set; } = idUser;
    public int IdSkill { get; set; } = idSkill;
    public Skill Skill { get; set; }
}