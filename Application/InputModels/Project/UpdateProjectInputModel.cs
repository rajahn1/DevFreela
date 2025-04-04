using Domain.Entities;
using Domain.Enums;

namespace Application.InputModels;

public class UpdateProjectInputModel
{
    public int Id { get; set; } 
    public string Description { get;  set; }
    public string Title { get; set; }
    public decimal TotalCost { get; set; }
}