using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public class SystemNotification : Notification
    {

        public SystemNotification(Guid systemUserId) : base("System")
        {
            
        }

        public void AddMessage(string message)
        {
            Message = message;
        }
        public override string GetMessage()
        {
            return $"System notification: {Message}";
        }
    }
}
