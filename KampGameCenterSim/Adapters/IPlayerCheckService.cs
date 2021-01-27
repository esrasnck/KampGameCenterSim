using KampGameCenterSim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampGameCenterSim.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPlayer(Player player);
    }
}
