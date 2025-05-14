public class Todo
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public bool IsCompleted { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
}