
using System.ComponentModel.DataAnnotations;

public class Space
{
    [Key]
    public Guid IdSpace { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public Guid IdUser { get; set; }
    public List<Task> Tasks{ get; set; }
    
    public User User { get; set; }
}