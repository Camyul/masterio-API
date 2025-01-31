using System.ComponentModel.DataAnnotations;

namespace Masterio.Server.Data.Models.Identity
{
    public class LoginRequestModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
