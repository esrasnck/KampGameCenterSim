using KampGameCenterSim.Abstract;
using KampGameCenterSim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampGameCenterSim.Concrete
{
    public class CampainManager:ICampainService
    {
        public  void Add(Campain entity)
        {
            Console.WriteLine($"{entity.Discount} indirim oranlı {entity.CampainName}  kapmanyası eklendi.");
        }

        public void Update(Campain entity)
        {
            Console.WriteLine($"{entity.Discount} indirim oranlı {entity.CampainName} kampanyası güncellendi.");
        }

        public  void Delete(Campain entity)
        {
            Console.WriteLine($"{entity.Discount} indirim oranlı {entity.CampainName} kampanyası silindi.");
        }

        public void CalculateCampaign(Game game, Campain campain)  // bu metod buraya özgü ama bir yerde hata var.
        {
            Console.WriteLine($"{game.NameOfGame} isimli oyuna, {campain.CampainName} isimli kampanya uygulandı. {campain.Discount} kadarlık indirim uygulandı");
        }
    }
}
