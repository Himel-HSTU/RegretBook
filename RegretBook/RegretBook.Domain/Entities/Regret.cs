using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public class Regret
    {
        private Guid _id;
        private Guid _userId;
        private string _description;
        private DateTime _createdAt;

        public Regret()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id { get { return _id; } }
        public Guid UserId { get { return _userId; } set { _userId = value; } }
        public string Description { get { return _description; } set {  _description = value; } }
        public DateTime CreatedAt { get { return _createdAt; } }
    }
}
