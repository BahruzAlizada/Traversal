using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string TitleOne { get; set; }
        public string DescriptionOne { get; set; }
        public string TitleTwo { get; set; }
        public string DescriptionTwo { get; set; }
    }
}
