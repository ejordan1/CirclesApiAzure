using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessagesServer.Models
{
    [Table("messages")]
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string UserName { get; set; }

        public string MessageText { get; set; }

        public int MessagerNumber { get; set; }

        public string MessageNote { get; set; }
    }
}