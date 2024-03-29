﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoRAPI.Data.Repositories
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        
        TEntity GetById(long pId);

        IEnumerable<TEntity> GetMultipleById(IEnumerable<long> pIds);

        void Add(TEntity pEntity);

        void Update(TEntity pDbEntity, TEntity pEntity);

        void Delete(TEntity pEntity);
    }
}
