using KampGameCenterSim.Abstract;
using KampGameCenterSim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampGameCenterSim.Concrete
{
    public class PlayerManager :IPlayerService
    {

    
        public void Add(Player entity)
        {
             Console.WriteLine($"{entity.FirstName} {entity.LastName} isimli oyuncu eklendi.");
        }
        public void Update(Player entity)
        {
            Console.WriteLine($"{entity.FirstName} {entity.LastName} isimli oyuncu güncellendi.");
        }
        public void Delete(Player entity)
        {
            Console.WriteLine($"{entity.FirstName} {entity.LastName} isimli oyuncu silindi.");
        }


      
    }
}
