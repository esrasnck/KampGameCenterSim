using KampGameCenterSim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampGameCenterSim.Abstract
{
    public interface ISaleService
    {
        void Sale(Player player, Game game);

        void SaleWithCampain(Game game,Campain campain);
    }
}
