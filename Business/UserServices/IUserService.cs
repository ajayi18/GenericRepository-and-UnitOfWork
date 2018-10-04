using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.UserServices
{
    public interface IUserService
    {
        int addUser(User entity);
    }
}
