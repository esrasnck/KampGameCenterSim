using KampGameCenterSim.Abstract;
using KampGameCenterSim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampGameCenterSim.Concrete
{
   public class AuthManager: IAuthService
    {
        IPlayerCheckService _playerCheckService;
        public AuthManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Register(Player player)
        {
            if (_playerCheckService.CheckIfRealPlayer(player))
            {
                Console.WriteLine($"{player.FirstName} {player.LastName} isimli oyuncu eklendi.");
            }
            else
            {
                Console.WriteLine($"{player.FirstName} {player.LastName} isimli kişi bulunamadı.");
            }
        }
    }
}
