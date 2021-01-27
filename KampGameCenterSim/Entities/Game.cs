using KampGameCenterSim.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampGameCenterSim.Entities
{
    public class Game:BaseEntity
    {
        public string NameOfGame { get; set; }

        public decimal UnitPrice { get; set; }


    }
}
