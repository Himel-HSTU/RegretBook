using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public class Share : BaseEntity
    {
        private Guid _userId;
        private Guid _regretId;
        private string _comment;

        public Share() : base(Guid.NewGuid())
        {
            
        }
        public Guid UserId { get { return _userId; } set { _userId = value; } }
        public Guid RegretId { get { return _regretId; } set { _regretId = value; } }
        public string Comment { get { return _comment; } set { _comment = value; } }
    }
}
