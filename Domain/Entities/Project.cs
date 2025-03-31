using Domain.Enums;

namespace Domain.Entities;

public class Project(string title, string description, decimal totalCost, int idClient, int idFreelancer): BaseEntity
{
    public string Title { get; private set; } = title;
    public string Description { get; private set; } = description;
    public int IdClient { get; private set; } = idClient;
    public int IdFreelancer { get; private set; } = idFreelancer;
    public decimal TotalCost { get; private set; } = totalCost;
    public DateTime? StartedAt { get; private set; }
    public DateTime? FinishedAt { get; private set; }
    public ProjectStatusEnum Status { get; private set; } = ProjectStatusEnum.Created;
    public List<ProjectComment> Comments { get; private set; } = [];
}