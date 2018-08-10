using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDManagerApi.Models
{
    public class Character : Tagable
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Alignment { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public Inventory CharacterInventory { get; set; }
    }
}
