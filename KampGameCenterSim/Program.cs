using KampGameCenterSim.Abstract;
using KampGameCenterSim.Adapters;
using KampGameCenterSim.Concrete;
using KampGameCenterSim.Entities;
using System;

namespace KampGameCenterSim
{
    class Program
    {
      static void Main(string[] args)
        {

            #region Register kısmı

            Console.WriteLine("Kimlik Numarası girin :");
            string kimlikNo = Console.ReadLine();

            Console.WriteLine("İsim girin :");
            string isim = Console.ReadLine();

            Console.WriteLine("Soy isim girin :");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Doğum tarihi girin (Yıl,ay,gün) :");
            DateTime dogumTarihi = Convert.ToDateTime(Console.ReadLine());

            Player player = new Player();
            player.FirstName = isim;
            player.LastName = soyisim;
            player.TimeOfBirth = dogumTarihi;
            player.NationalIdentityNumber = kimlikNo;

            IAuthService authService = new AuthManager(new MernisServiceAdapter());
            authService.Register(player);

            #endregion

            #region veriler

            Game game = new Game() { ID = 1, NameOfGame = "Counter Strike", UnitPrice = 10 };
            Game game1 = new Game() { ID = 2, NameOfGame = "Counter Strike1", UnitPrice = 15 };
            Game game2 = new Game() { ID = 3, NameOfGame = "Counter Strike2", UnitPrice = 20 };

            Player player1 = new Player() { ID = 1, FirstName = "Alp", LastName = "Aygul", TimeOfBirth = new DateTime(2010, 12, 10), NationalIdentityNumber = "12311230" };
            Player player2 = new Player() { ID = 2, FirstName = "Mert", LastName = "Aygul", TimeOfBirth = new DateTime(2012, 10, 12), NationalIdentityNumber = "165474776" };
            Player player3 = new Player() { ID = 3, FirstName = "Ahmet", LastName = "Senbabaoglu", TimeOfBirth = new DateTime(2013, 10, 12), NationalIdentityNumber = "12232432432" };

            Campain campain = new Campain() { ID = 1, CampainName = "Black Friday", Discount = 0.2 };
            Campain campain2 = new Campain() { ID = 2, CampainName = "Black Monday", Discount = 0.4 };
            Campain campain3 = new Campain() { ID = 3, CampainName = "Black Thursday", Discount = 0.3 };
            #endregion

            #region oyun satış simulasyonu kısmı

            SaleManager saleManager = new SaleManager(new CampainManager());
            saleManager.Sale(player1, game2);

            saleManager.SaleWithCampain(game1, campain2);
            #endregion


            #region Kampanya simuliasyonu

            CampainManager campainManager = new CampainManager();
            campainManager.Add(campain);
            campainManager.Update(campain2);
            campainManager.Delete(campain3);
            #endregion




        }
    }
}
