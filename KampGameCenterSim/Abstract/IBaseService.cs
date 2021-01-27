using KampGameCenterSim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampGameCenterSim.Abstract
{
   public interface IBaseService<T> where T:BaseEntity
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);



        
    }
}
