using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CertificatePRJ.Service.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        //private ApplicationDbContext _context;

        //public UnitOfWork(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        //public Task<bool> RunTransaction(
        //  Func<Task> sequence,
        //  IsolationLevel isolationLevel = IsolationLevel.Serializable)
        //{
        //    return _context.Database
        //        .CreateExecutionStrategy()
        //        .ExecuteAsync(async () =>
        //        {
        //            var result = true;
        //            using var transaction = await _context.Database.BeginTransactionAsync(isolationLevel);

        //            await sequence();
        //            await transaction.CommitAsync();

        //            return result;
        //        });
        //}

        //public Task<int> SaveChangesAsync()
        //{
        //    return _context.SaveChangesAsync();
        //}
    }
}
