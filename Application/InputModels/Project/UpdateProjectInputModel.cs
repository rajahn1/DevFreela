using Domain.Entities;
using Domain.Enums;

namespace Application.InputModels;

public class UpdateProjectInputModel(int id, string description, string title, decimal totalCost)
{
    public int Id { get; set; } = id;
    public string Description { get;  set; } = description;
    public string Title { get; set; } = title;
    public decimal TotalCost { get; set; } = totalCost;
}