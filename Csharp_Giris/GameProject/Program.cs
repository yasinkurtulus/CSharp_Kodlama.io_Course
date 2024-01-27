using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Users yasin = new Users{ Name="Yasin",Surname="Kurtulus",BirthYear=2003,TcNo=456465465};
            Users bilal = new Users{ Name="Bilal",Surname="Durmus",BirthYear=2003,TcNo=786456456};
            UserCheckManager userCheckManager = new UserCheckManager();
            Campaign efsanecuma = new Campaign { Name = "Efsane cuma", Discount = 20 };
            UserManager usermanager = new UserManager(userCheckManager);
            usermanager.Register(yasin);
            usermanager.SellGame(yasin, efsanecuma);
            usermanager.Deleteuser(bilal);
            usermanager.Deleteuser(yasin);
           

        }
    }
}
