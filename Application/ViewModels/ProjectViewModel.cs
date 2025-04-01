namespace Application.ViewModels;

public class ProjectViewModel(string title, DateTime createdAt)
{
    public string Title { get; private set; } = title;
    public DateTime CreatedAt { get; private set; } = createdAt;
}