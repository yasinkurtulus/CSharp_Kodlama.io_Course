using GameProject.Absrtact;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void addCampgain(Campaign campaign)
        {
            Console.WriteLine("campaign has been added");
        }
    }
}
