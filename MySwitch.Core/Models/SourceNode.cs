using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwitch.Core.Models
{

    public class SourceNode
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Host Name")]
        public string HostName { get; set; }

        [Display(Name = "IP Address")]
        public string IPAddress { get; set; }
        public string Port { get; set; }
        public Status Status { get; set; }
        public Scheme Scheme { get; set; }
        public int SchemeId { get; set; }
        public IEnumerable<Scheme> Schemes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
