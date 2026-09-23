using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public Guid RequestByUserId { get; set; }   
        public FriendRequestNotification(Guid requestByUserId) : base("Friend Request")
        {
            RequestByUserId = requestByUserId;
        }

        public void AddMessage(string message)
        {
            Message = message;
        }
        public override string GetMessage()
        {
            return $"User {RequestByUserId} sent you a friend request.";
        }
    }
}
