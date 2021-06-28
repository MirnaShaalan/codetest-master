using DomainModels.EF_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserEntity> GetUsers();
        UserEntity GetUser(Guid id);
        void InsertUser(UserEntity user);
        UserEntity UpdateUser(UserEntity user);
        void DeleteUser(Guid id);
    }
}
