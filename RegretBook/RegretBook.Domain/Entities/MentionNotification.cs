using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public class MentionNotification : Notification
    {
        public MentionNotification(Guid mentionedByUserId) : base("Mention")
        {
            
        }
        public override string GetMessage()
        {
            return $"User Mentioned you in a regret.";
        }
    }
}
