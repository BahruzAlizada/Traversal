using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string Image { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price{get;set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool Featured { get; set; }
        public bool IsDeactive { get; set; }
        public DestinationDetail DestinationDetail { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
