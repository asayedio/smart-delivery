//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartDelivery.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public int ID { get; set; }
        public int SenderID { get; set; }
        public int RecipientId { get; set; }
        public string MessageContent { get; set; }
        public System.DateTime Sent_DateTime { get; set; }
        public bool Seen { get; set; }
        public Nullable<System.DateTime> Seen_DateTime { get; set; }
    }
}