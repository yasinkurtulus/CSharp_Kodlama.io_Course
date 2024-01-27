using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Absrtact
{
   public interface IUserCheckService
    {
        bool CheckInformation(Users user);
        bool IsRegister(Users user,List<Users> list);
    }
}
