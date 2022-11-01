using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    public class AddFriend
    {
        public int Id { get; set; } 
        public string SenderEmail { get;  }
        public string RecipientEmail { get;  }

        public AddFriend(int id, string senderEmail, string recipientEmail)
        {
            this.Id = id;
            this.SenderEmail = senderEmail;
            this.RecipientEmail = recipientEmail;
        }   
    }
}
