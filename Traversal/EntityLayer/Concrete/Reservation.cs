using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int PersonCount { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }= DateTime.UtcNow.AddHours(4);
        public bool IsDeactive { get; set; }
        public string Status { get; set; }
        public int DestinationnId { get; set; }
        public Destination Destinationn { get; set; }
    }
}
