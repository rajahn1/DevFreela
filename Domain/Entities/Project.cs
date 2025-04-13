using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums;

namespace Domain.Entities;

public class Project(string title, string description, decimal totalCost, int idClient, int idFreelancer) : BaseEntity
{
    public string Title { get; private set; } = title;
    public string Description { get; private set; } = description;
    public User Client { get; private set; }
    public int IdClient { get; private set; } = idClient;
    public User Freelancer { get; private set; }
    public int IdFreelancer { get; private set; } = idFreelancer;
    public decimal TotalCost { get; private set; } = totalCost;
    public DateTime? StartedAt { get; private set; }
    public DateTime? FinishedAt { get; private set; }
    public ProjectStatusEnum Status { get; private set; } = ProjectStatusEnum.Created;
    public List<ProjectComment> Comments { get; private set; } = [];

    public void Cancel()
    {
        if (Status is ProjectStatusEnum.InProgress or ProjectStatusEnum.Created)
        {
            Status = ProjectStatusEnum.Cancelled;
        }
    }

    public void Start()
    {
        if (Status is not ProjectStatusEnum.Created) return;
        Status = ProjectStatusEnum.InProgress;
        StartedAt = DateTime.Now;
    }

    public void Finish()
    {
        if (Status is not ProjectStatusEnum.InProgress) return;
        Status = ProjectStatusEnum.Finished;
        FinishedAt = DateTime.Now;
    }
    
    public void Update(string title, string description, decimal totalCost, int id)
    {
        Title = title;
        Description = description;
        TotalCost = totalCost;
        Id = id;
    }
}