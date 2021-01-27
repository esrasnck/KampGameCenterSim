using KampGameCenterSim.Abstract;
using KampGameCenterSim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampGameCenterSim.Concrete
{
    public class SaleManager : ISaleService
    {
        ICampainService _campainService;
        public SaleManager(ICampainService campainService)
        {
            _campainService = campainService;
        }

        public void Sale(Player player, Game game)
        {
            Console.WriteLine($"{player.FirstName} {player.LastName} isimli oyuncu, {game.NameOfGame} isimli oyunu aldı.");
        } 

        public void SaleWithCampain(Game game,Campain campain)
        {
            _campainService.CalculateCampaign(game, campain);

        }

    }
}
