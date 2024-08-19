namespace API.DTOs
;
//koristimo ovaj file za vracanje useram npm kad se neko login ili sta vec, da ne vracamo ceo objekat
public class UserDto
{
    public required string Username { get; set; }
    public required string  Token { get; set; }
}
