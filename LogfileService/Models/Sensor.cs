using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogfileService.Models
{
    public class Sensor
    {
        public int ID { get; set; }
        public string Alarm { get; set; }
        public DateTime Tid { get; set; }
        public Bolig Bolig { get; set; }
    }
}