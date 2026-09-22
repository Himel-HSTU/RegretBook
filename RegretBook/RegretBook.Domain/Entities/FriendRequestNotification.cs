using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public FriendRequestNotification(Guid friendRequestId) : base("Friend Request")
        {
            
        }
        public override string GetMessage()
        {
            return $"User sent you a friend request.";
        }
    }
}
