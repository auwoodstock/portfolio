using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Interfaces;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class UserBasicDataServices : IUserBasicData
    {
        public Task<IEnumerable<UserBasicData>> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
