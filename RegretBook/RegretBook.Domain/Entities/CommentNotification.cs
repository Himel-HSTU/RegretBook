using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public class CommentNotification : Notification
    {
        public CommentNotification(Guid commentByUserId) : base("Comment")
        {
            
        }
        public override string GetMessage()
        {
            return $"User commented on your regret.";
        }
    }
}
