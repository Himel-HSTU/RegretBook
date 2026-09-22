using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public class Bookmark : BaseEntity
    {
        private Guid _userId;
        private Guid _regretId;

        public Bookmark() : base (Guid.NewGuid())
        {
            
        }
         
        public Guid UserId { get { return _userId; } set { _userId = value; } }
        public Guid RegretId { get { return _regretId; } set { _regretId = value; } }
    }
}
