namespace Application.ViewModels;

public class ProjectDetailsViewModel(
    int id,
    string description,
    decimal totalCost,
    DateTime startedAt,
    string title,
    DateTime finishedAt,
    string freelancerFullName,
    string clientFullName
    )
{
    public int Id { get; private set; } = id;
    public string Description { get; private set; } = description;
    public decimal TotalCost { get; private set; } = totalCost;
    public DateTime StartedAt { get; private set; } = startedAt;
    public string Title { get; private set; } = title;
    public DateTime FinishedAt { get; private set; } = finishedAt;
    public string FreelancerFullName { get; private set; } =  freelancerFullName;
    public string ClientFullName { get; private set; } = clientFullName;
}