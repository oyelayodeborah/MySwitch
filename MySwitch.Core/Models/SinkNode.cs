using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwitch.Core.Models
{
    public enum Status
    {
        [Display(Name="Active")]
        Active,

        [Display(Name = "InActive")]
        InActive
    }
    public class SinkNode
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Host Name")]
        public string HostName { get; set; }
        public string IPAddress { get; set; }
        public string Port { get; set; }
        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
