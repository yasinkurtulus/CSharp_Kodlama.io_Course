using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Absrtact
{
    public interface IUserService
    {
        void Register(Users users);
        void Deleteuser(Users user);
        void UpdateInformation(Users user,Users user2);
        void SellGame(Users user,Campaign campgain);
    }
}
