using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traversal.ViewsModel
{
    public class UpdateMemberVM
    {
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage ="Name can not be null")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Surname can not be null")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Username can not be null")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Email can not be null")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage ="Phone can not be null")]
        public string Phone {  get; set; }


        [Required(ErrorMessage = "Password can not be null")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Password can not be null")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Check Password can not be null")]
        [DataType(DataType.Password)]
        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; }
    }
}
