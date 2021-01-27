using KampGameCenterSim.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampGameCenterSim.Entities
{
    public abstract class BaseEntity:IEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }
        public int ID { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public DateTime? DeletedDate { get; set; }
    }
}
