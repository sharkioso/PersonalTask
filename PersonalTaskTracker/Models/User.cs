
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public Guid IdUser { get; set; } = Guid.NewGuid();
    public string Login { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public List<Space> Spaces { get; set; }


}