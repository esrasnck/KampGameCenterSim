using KampGameCenterSim.Abstract;
using KampGameCenterSim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampGameCenterSim.Concrete
{
    public class PlayerCheckService : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            return true;

        }
    }
}
