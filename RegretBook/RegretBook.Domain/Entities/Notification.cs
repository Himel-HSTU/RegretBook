using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public abstract class Notification : BaseEntity  
    {
        private Guid _userId;
        private string _type;
        private string _message;
        private bool _isRead;

        public Notification (string notificationType) : base(Guid.NewGuid())
        {
            _type = notificationType;
        }

        public Guid UserId { get { return _userId; } set { _userId = value; } }
        public string Type { get { return _type; } set { _type = value; } }
        protected string Message { get { return _message; } set { _message = value; } }
        public bool IsRead { get { return _isRead; } set { _isRead = value; } }

        public abstract string GetMessage(); // child classes must implement this method to provide their own message

        //public virtual string GetMessage()
        //{
        //    return "General Notification";
        //}   
    }
}
