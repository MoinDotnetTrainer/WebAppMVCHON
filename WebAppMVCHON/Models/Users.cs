using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace WebAppMVCHON.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="UserName Required")]
        public string? Username { get; set; }

        [Required(ErrorMessage ="Email Required")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Password Required")]
        public string? Password { get; set; }

        public List<UsersTask>? AssignedTasks { get; set; }
    }
}
