using System;
using Repository.Models;
using Repository.Repositories;
using Repository.Context;
using Repository.IUnitOfWork;

namespace Business.UserServices
{
    public class UserService : IUserService
    {
        private EFContext dbContext;
        private readonly IRepository<User> userRepository;
        private IUnitOfWork uow;

        public UserService()
        {
            dbContext = new EFContext();
            uow = new EFUnitOfWork(dbContext);
            userRepository = new EFRepository<User>(dbContext);
        }

        public int addUser(User entity)
        {
            User user = new User
            {
                FirstName = "John",
                LastName = "Doe",
                CreatedDate = DateTime.Now,
                Email = "nok@nokki.com",
                Password = "123"
            };
            userRepository.Add(user);
            return uow.SaveChanges();
        }
    }
}
