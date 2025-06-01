
using System.ComponentModel.DataAnnotations;

public class Task
{
    [Key]
    public Guid IdTask { get; set; } = Guid.NewGuid();
    public Guid IdSpace{ get; set; }
    public string Name { get; set; }
    public string Discription { get; set; }
    public TaskStatus Status { get; set; }

    public Space Space { get; set; }

}