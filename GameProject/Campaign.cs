using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public int CampaignPrice { get; set; }
    }
}
