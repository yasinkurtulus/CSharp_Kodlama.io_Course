using GameProject.Absrtact;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserCheckManager : IUserCheckService
    {
        public bool CheckInformation(Users user)
        {
            Console.WriteLine("Information are true");
            return true;
        }

        public bool IsRegister(Users user,List<Users> userList)
        {
            if (userList.Contains(user))
            {
               return true;
            }
            else
            {
               return false;
            }
        }
    }
}
