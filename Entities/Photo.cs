using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities;

[Table("Photos")]
public class Photo
{
    public int Id { get; set; }
    public required string Url { get; set; }
    public bool IsMain { get; set; }
    public string? PublicId { get; set; }

    // Navigation properties, da ne bi bila slika ne vezana za appusera, lek 81 entity framework relationships
    public int AppUserId { get; set; }
    public AppUser AppUser { get; set; } = null!;
}