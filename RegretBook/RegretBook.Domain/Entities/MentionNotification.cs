using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public class MentionNotification : Notification
    {
        public Guid MentionedByUserId { get; set; }
        public MentionNotification(Guid mentionedByUserId) : base("Mention")
        {
            MentionedByUserId = mentionedByUserId;
        }
        public override string GetMessage()
        {
            return $"User {MentionedByUserId} Mentioned you in a regret.";
        }
    }
}
