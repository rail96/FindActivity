using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindActivity.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
