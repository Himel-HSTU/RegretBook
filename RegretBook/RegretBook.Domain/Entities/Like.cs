using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public class Like : BaseEntity
    {
       
        private Guid _regretId;
        private Guid _userId;
        private string _reactionType;
        public Like() : base(Guid.NewGuid())
        {
            // Id is initialized in BaseEntity constructor 
        }

        public Guid UserId { get { return _userId; } set { _userId = value; } }
        public Guid RegretId { get { return _regretId; } set { _regretId = value; } }
        public string? ReactionType { get { return _reactionType; } set { _reactionType = value; } }
        
    }
}
