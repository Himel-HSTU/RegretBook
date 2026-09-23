using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public class Regret : BaseEntity, ILikeable
    {
        private Guid _userId;
        private string _description;

        public Regret(string description) : base(Guid.NewGuid()) // Constructor chaining to BaseEntity
        {
            _description = description;
        }

        public Guid UserId { get { return _userId; } set { _userId = value; } }
        public string Description { get { return _description; } set {  _description = value; } }

        public bool CanBeLiked() 
        {
            return true;
        }
    }
}
