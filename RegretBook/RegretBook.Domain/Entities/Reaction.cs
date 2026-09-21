using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public class Reaction
    {
        private Guid _userId;
        private Guid _regretId;
        private string _reactionType;
        private DateTime _reactedAt;
        public Reaction()
        {
            _reactedAt = DateTime.UtcNow;
        }
        public Guid UserId { get { return _userId; } set { _userId = value; } }
        public Guid RegretId { get { return _regretId; } set { _regretId = value; } }
        public string? ReactionType { get { return _reactionType; } set { _reactionType = value; } }
        public DateTime ReactedAt { get { return _reactedAt; } set { _reactedAt = value; } }
    }
}
