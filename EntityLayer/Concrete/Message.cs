using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string MSubject { get; set; }
        public string MDetails { get; set; }
        public bool MStatus { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
