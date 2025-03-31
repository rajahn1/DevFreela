using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class DevFreelaDbContext: DbContext
{
    public DevFreelaDbContext()
    {
        Projects = new List<Project>
        {
            new Project("Angular com C#", "projeto teste lorem", 11900),
            new Project("React com Tailwind", "lorem ipsum dolorers", 19032),
            new Project("Next com Vanilla", "avada kedavra", 1129)
        };

        Users = new List<User>
        {
            new User("Rafael Felipe", "rafayuno@gmail.com", new DateTime(2001, 9, 1)),
            new User("Daniel Felipe", "dani@gmail.com", new DateTime(2000, 4, 24)),
            new User("Cassiano Felipe", "cassi@gmail.com", new DateTime(1998, 8, 28))
        };

        Skills = new List<Skill>
        {
            new Skill("C#"),
            new Skill("SQL"),
            new Skill("Javascript")
        };
    }
    
    
    public List<Project>Projects { get; set; }
    public List<User>Users { get; set; }
    public List<Skill>Skills { get; set; }
}