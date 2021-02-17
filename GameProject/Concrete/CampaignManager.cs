using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : BaseManager<Campaign>
    {
        public override void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Campaign Added");
        }

        public override void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Campaign Deleted");
        }

        public override void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Campaign Updated");
        }
    }
}
