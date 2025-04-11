using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace WebAppMVCHON.Models
{
    public class UsersTask
    {

        [Key]
        public int TaskId { get; set; }

        [Required(ErrorMessage = "Title Required")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Description Required")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "DueDate Required")]
        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Status Required")]
        public string? Status { get; set; }

        [Required(ErrorMessage = "AssignedUserId Required")]
        public int AssignedUserId { get; set; }// userid will be given , to a specif user this task is assigned
        public Users? AssignedUser { get; set; } // navigation to user info
    }
}
