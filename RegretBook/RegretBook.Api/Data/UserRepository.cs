using RegretBook.Domain.Entities;

namespace RegretBook.Api.Data
{
    public class UserRepository
    {
        private List<User> _users { get; set; } = new List<User>();
        public User AddUser(User user)
        {
            _users.Add(user);
            
            return user;
        }

        public User UpdateUser(User user)
        {
            _users.RemoveAll(u => u.Id == user.Id);
            _users.Add(user);
            return user;
        }
        public bool DeleteUser(Guid id) {
            var user = GetUserById(id);
            if (user != null)
            {
                _users.Remove(user);
                return true;
            }
            return false;
        }
        public User? GetUserById(Guid id)
        {
            return _users.SingleOrDefault(u => u.Id == id);
        }

        public List<User> GetUsers()
        {
            return _users;
        }
        public User? GetUserByEmail(string email)
        {
            return _users.SingleOrDefault(u => u.Email == email);
        }
    }
}
