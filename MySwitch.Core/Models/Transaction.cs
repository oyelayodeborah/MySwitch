using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwitch.Core.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string CardPAN { get; set; }
        public decimal Amount { get; set; }  //exclusive of the transaction fee
        public decimal TransactionFee { get; set; }  //A fee charged, by the acquirer to the issuer, for transaction activity, in the currency of the amount, transaction.
        public decimal ProcessingFee { get; set; }
        public DateTime Date { get; set; }
        public string MTI { get; set; }     //Message Type Identifier
        public string STAN { get; set; }    //System Trace Audit Number
        public string ChannelCode { get; set; }
        public string OriginalDataElement { get; set; }

        public string TransactionTypeCode { get; set; }
        public string Account1 { get; set; }    //"from" account number (payer)
        public string Account2 { get; set; }    //"To" account number (payee)
        public string FeeCode { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
        public bool IsReversePending { get; set; }
        public bool IsReversed { get; set; }
        public SourceNode SourceNode { get; set; }
        public int SourceNodeId { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
