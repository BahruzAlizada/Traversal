﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
    }
}
