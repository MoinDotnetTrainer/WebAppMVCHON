using System.ComponentModel.DataAnnotations;

namespace WebAppMVCHON.Models
{
    public class LoginModel
    {

        [Required]
        public string? EmailId { get; set; }


        [Required]
        public string? Password { get; set; }
    }
}
