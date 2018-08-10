using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDManagerApi.Models
{
    public class Location
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string PartyReputation { get; set; }
    }
}
