using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public class Reaction : BaseEntity
    {
       
        private Guid _regretId;
        private string _reactionType;
        public Reaction() : base(Guid.NewGuid())
        {
            // Id is initialized in BaseEntity constructor 
        }

        public Guid RegretId { get { return _regretId; } set { _regretId = value; } }
        public string? ReactionType { get { return _reactionType; } set { _reactionType = value; } }
        
    }
}
