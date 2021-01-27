using KampGameCenterSim.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampGameCenterSim.Entities
{
    public class Player:BaseEntity
    {
        public string NationalIdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime TimeOfBirth { get; set; }

    }
}
