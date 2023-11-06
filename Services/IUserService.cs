using InsuranceApp.Models;

namespace InsuranceApp.Services
{
    public interface IUserService
    {
        public List<User> GetAll();
        public User Get(int id);
        public User Check(int id);
        public int Add(User user);
        public User Update(User user);
        public void Delete(User user);
    }
}
