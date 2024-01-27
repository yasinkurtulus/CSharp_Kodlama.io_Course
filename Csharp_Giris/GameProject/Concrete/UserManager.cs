using GameProject.Absrtact;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserManager : IUserService     
    {
       public List<Users> userList=new List<Users>();
        UserCheckManager userCheckManager;
        public UserManager(UserCheckManager usercheckmanager)
        {
            userCheckManager = usercheckmanager;
        }
        public void Deleteuser(Users user)
        {
            if (userCheckManager.IsRegister(user,userList) == true)
            {
                Console.WriteLine("User has been removed");
                userList.Remove(user);
            }
            else
            {
                Console.WriteLine("this user is not valid ");
            }
        }

        public void Register(Users user)
        {
            if (userCheckManager.IsRegister(user,userList)!=true&&userCheckManager.CheckInformation(user)==true)
            {
                Console.WriteLine("User added");
                userList.Add(user);
            }
            else
            {
                Console.WriteLine("User can not add, user already added before");
            }
            
        }

        public void SellGame(Users user,Campaign campaign)
        {
            Console.WriteLine("game has been sold with "+campaign.Name);
            Console.WriteLine("Discount:"+campaign.Discount);
        }

        public void UpdateInformation(Users user,Users user2)
        {
            if (userCheckManager.IsRegister(user,userList) != true)
            {
                user.BirthYear = user2.BirthYear;
                user.Name = user2.Name;
                user.Surname = user2.Surname;
                user.TcNo = user2.TcNo;
            }
           
          
        }
    }
}
