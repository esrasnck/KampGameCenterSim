using KampGameCenterSim.Abstract;
using KampGameCenterSim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampGameCenterSim.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game entity)
        {
            Console.WriteLine($"{entity.NameOfGame} isimli oyun eklendi.");
        }

        public void Delete(Game entity)
        {
            Console.WriteLine($"{entity.NameOfGame} isimli oyun silindi.");
        }

        public void Update(Game entity)
        {
            Console.WriteLine($"{entity.NameOfGame} isimli oyun güncellendi.");
        }
    }
}
