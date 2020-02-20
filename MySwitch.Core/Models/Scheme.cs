using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwitch.Core.Models
{
    public class Scheme
    {
        public int Id { get; set; }
        public Route Route { get; set; }
        public int RouteId { get; set; }
        public Combo Combo{ get; set; }
        public int ComboId { get; set; }

        public string Description { get; set; }
        public IEnumerable<Route> Routes { get; set; }
        public IEnumerable<Combo> Combos { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

    }
}
