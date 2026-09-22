using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public class Follow : BaseEntity
    {
        private Guid _followerId;
        private Guid _followingId;

        public Follow() : base(Guid.NewGuid())
        {
            
        }

        public Guid FollowerId { get { return _followerId; } set { _followerId = value; } }
        public Guid FollowingId { get { return _followingId; } set { _followingId = value; } }
    }
}
