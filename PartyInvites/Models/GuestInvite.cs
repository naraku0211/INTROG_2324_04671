using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    public class GuestInvite
    {
        [Required(ErrorMessage = "Please enter Name.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please input email address.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please input correct phone/cell number.")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Please specified if you will attend.")]
        public bool? WillAttend { get; set; }
   
    }
}
