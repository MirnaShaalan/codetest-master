using DomainModels.EF_Models;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<UserEntity> userRepository;

        public UserService(IRepository<UserEntity> userRepository)
        {
            this.userRepository = userRepository;
        }

        public IEnumerable<UserEntity> GetUsers()
        {
            return userRepository.GetAll();
        }

        public UserEntity GetUser(Guid id)
        {
            return userRepository.Get(id);
        }

        public void InsertUser(UserEntity user)
        {
            user.CreatedAt = DateTime.Now;
            userRepository.Insert(user);
        }
        public UserEntity UpdateUser(UserEntity user)
        {
            //user.CreatedAt = userRepository.Get(user.Id).CreatedAt;
            user.ModifiedAt = DateTime.Now;
            var userEntity = user;
            userRepository.Update(userEntity);
            return userEntity;
        }

        public void DeleteUser(Guid id)
        {
            UserEntity user = GetUser(id);
            userRepository.Remove(user);
            userRepository.SaveChanges();
        }
    }
}
