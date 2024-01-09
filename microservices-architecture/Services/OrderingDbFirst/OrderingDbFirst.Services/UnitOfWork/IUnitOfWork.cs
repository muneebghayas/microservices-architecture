using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Threading.Tasks;

namespace CertificatePRJ.Service.UnitOfWork
{
    public interface IUnitOfWork
    {
        //Task<bool> RunTransaction(Func<Task> sequence, IsolationLevel isolationLevel = IsolationLevel.Serializable);
        //Task<int> SaveChangesAsync();
    }
}
