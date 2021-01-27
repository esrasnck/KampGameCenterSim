using KampGameCenterSim.Abstract;
using KampGameCenterSim.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampGameCenterSim.Adapters
{
   public class MernisServiceAdapter:IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            var result = client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(player.NationalIdentityNumber), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.TimeOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;

            // todo: bir köşede kalsın. çözmek gerek
            return result;

        }
    }
}
