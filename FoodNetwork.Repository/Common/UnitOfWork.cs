﻿using FoodNetwork.Data.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Repository
{
    /// <summary>
    /// The Entity Framework implementation of IUnitOfWork
    /// </summary>
    public sealed class UnitOfWork : IUnitOfWork, IDisposable
    {
        /// <summary>
        /// The DbContext
        /// </summary>
        private  IFoodNetworkDatabaseContext _dbContext;
        private bool disposed = false;
        /// <summary>
        /// Initializes a new instance of the UnitOfWork class.
        /// </summary>
        /// <param name="context">The object context</param>
        public UnitOfWork(IConnectionStringBuilder connectionBuilder)
        {
            var factory = new FoodNetworkDataBaseConnectionFactory(connectionBuilder);      
            _dbContext = factory.GetDbContext();
           
        }
        /// <summary>
        /// Saves all pending changes
        /// </summary>
        /// <returns>The number of objects in an Added, Modified, or Deleted state</returns>
        public int Commit()
        {
            // Save changes with the default options
            return _dbContext.SaveChanges();
        }

        public IFoodNetworkDatabaseContext Context
        {
            get { return _dbContext; }
        }
        /// <summary>
        /// Disposes the current object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes all external resources.
        /// </summary>
        /// <param name="disposing">The dispose indicator.</param>
        private void Dispose(bool disposing)
        {     
            if (!disposed)
            {
                if (disposing)
                {
                    if (_dbContext != null)
                    {
                        _dbContext.Dispose();
                        _dbContext = null;
                    }
                }
            }
            disposed = true;
        }
    }
}