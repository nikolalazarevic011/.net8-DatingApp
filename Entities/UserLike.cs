
namespace API.Entities;

public class UserLike
{
    public AppUser SourceUser { get; set; } = null!;
    public int SourceUserId { get; set; }  //the user that's liking
    public AppUser TargetUser { get; set; } = null!;
    public int TargetUserId { get; set; }
}