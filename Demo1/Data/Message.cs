using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Data
{
    public class Message
    {
        //user_id,username,source_addr,destination_addr,message, message_id,reply_to
        public int Id { get; set; }
        public string Username { get; set; }
        public string SourceAddress { get; set; }
        public string DestinationAddress { get; set; }
        [StringLength(1024)]
        [Required]
        public string Content { get; set; }
        public string MessageId { get; set; }
        public string ReplyTo { get; set; }
        public virtual Customer Customer { get; set; }
        public System.DateTime DateCreated { get; set; }

    }
}
