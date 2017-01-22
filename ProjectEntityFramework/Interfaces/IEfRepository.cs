﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using RepositoryT.Infrastructure;

namespace ProjectEntityFramework.Interfaces
{
    public interface IEfRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        List<TDynamicEntity> GetDynamic<TTable, TDynamicEntity>(Expression<Func<TTable, object>> selector, Func<object, TDynamicEntity> maker) where TTable : class;
        List<TDynamicEntity> GetDynamic<TTable, TDynamicEntity>(Func<TTable, object> selector, Func<object, TDynamicEntity> maker) where TTable : class;
    }
}
