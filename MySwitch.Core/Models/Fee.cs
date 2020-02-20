using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwitch.Core.Models
{
    public class Fee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FlatAmount { get; set; }
        public string PercentOfTransaction { get; set; }
        public string Maximum { get; set; }
        public string Minimum { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
