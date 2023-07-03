using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.RegisterDTOs
{
    public class AddRegisterDTOs
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }  
        public string ConfirmPassword { get; set; }
        public DateTime CreateTime = DateTime.UtcNow.AddHours(4);
        public bool isDeactive { get; set; }
        public bool IsRemember { get; set; }
    }
}
