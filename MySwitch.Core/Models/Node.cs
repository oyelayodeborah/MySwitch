using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwitch.Core.Models
{
    public enum NodeType
    {
        Server, Client
    }
    public class Node
    {
        public string Name { get; set; }
        public string HostName { get; set; }
        public string IPAddress { get; set; }
        public int Port { get; set; }
        public Status Status { get; set; }      //node status
        public NodeType NodeType { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
