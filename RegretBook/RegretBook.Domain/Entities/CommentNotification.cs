using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public sealed class CommentNotification : Notification
    {
        public Guid CommentByUserId { get; set; }
        public CommentNotification(Guid commentByUserId) : base("Comment")
        {
            CommentByUserId = commentByUserId;
        }   

        public void AddMessage(string message)
        {
            Message = message;
        }
        public override string GetMessage()
        {
            return $"User {CommentByUserId} commented on your regret.";
        }
    }
}
