using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDManagerApi.Models
{
    public class Party
    {
        public List<Player> Players { get; set; }
        public List<Npc> KnownNpcs { get; set; }
        public Inventory PartyInventory { get; set; }
        public List<Location> LocationsKnown { get; set; }
    }
}
