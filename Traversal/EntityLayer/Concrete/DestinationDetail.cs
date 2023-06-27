using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class DestinationDetail
    {
        public int Id { get; set; }
        public string DescriptionBase { get; set; }
        public string DescriptionOne { get; set; }  
        public string DescriptionTwo { get; set; }
        public string ImageOne { get; set; }
        public string ImageTwo { get; set; }
        public Destination Destination { get; set; }
        [ForeignKey("Destination")]
        public int DestinationId { get; set; }
    }
}
