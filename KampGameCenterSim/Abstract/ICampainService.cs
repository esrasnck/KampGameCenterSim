using KampGameCenterSim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampGameCenterSim.Abstract
{
    public interface ICampainService:IBaseService<Campain>
    {
        void CalculateCampaign(Game game, Campain campain);
    }
}
