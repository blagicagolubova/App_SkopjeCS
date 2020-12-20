using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkopjeCS.Models
{   
    public class Charging_station
    {

        [Key]
        public int id { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public String amenity { get; set; }
        public String fee { get; set; }
        public String openingHours { get; set; }
        public String operatorCS { get; set; }
        public String socket { get; set; }
        public String tip { get; set; }
        public String address { get; set; }
        public String municipality { get; set; }
    }
}