using System.ComponentModel.DataAnnotations;

namespace JwtAuth.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
