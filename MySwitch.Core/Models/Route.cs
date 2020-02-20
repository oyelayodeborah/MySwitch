using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwitch.Core.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SinkNode SinkNode { get; set; }
        public int SinkNodeId { get; set; }
        public string CardPAN { get; set; }
        public string Description { get; set; }
        public IEnumerable<SinkNode> SinkNodes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
