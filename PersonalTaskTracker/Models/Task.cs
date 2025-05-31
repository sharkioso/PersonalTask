
public class Task
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Discription { get; set; }
    public TaskStatus status { get; set; }
    
    public Space Space { get; set; }

}