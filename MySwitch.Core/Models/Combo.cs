using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySwitch.Core.Models
{
    public class Combo
    {
        public string Name { get; set; }
        public TransactionType TransactionType { get; set; }
        public int TransactionTypeId { get; set; }
        public Channel Channel { get; set; }
        public int ChannelId { get; set; }
        public Fee Fee { get; set; }
        public int FeeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
