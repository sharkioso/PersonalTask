
public class Space
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid IdUser { get; set; }
    
    public User User { get; set; }
}