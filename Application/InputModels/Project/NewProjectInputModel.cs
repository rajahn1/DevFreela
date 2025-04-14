namespace Application.InputModels;

public class NewProjectInputModel(string title, string description, int idClient, int idFreelancer, decimal totalCost)
{
    public string Title { get; set; } = title;
    public string Description { get; set; } = description;
    public int IdClient { get; set;} = idClient;
    public int IdFreelancer { get; set;} = idFreelancer;
    public decimal TotalCost { get; set; } = totalCost;
}