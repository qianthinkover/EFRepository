﻿using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using RepositoryT.Infrastructure;
using ProjectEntityFramework.Interfaces;

namespace ProjectEntityFramework
{
    public class EfRepositoryBase<TContext> : RepositoryBase<TContext> 
        where TContext : class, IDbContext, IDisposable
    {
        public EfRepositoryBase(IServiceLocator serviceLocator) : base(serviceLocator)
        {
        }

        protected IDbSet<T> Set<T>() where T : class
        {
            return DataContext.Set<T>();
        }

        protected ObjectContext ObjectContextWrapper => DataContext.ObjectContext;
    }
}
