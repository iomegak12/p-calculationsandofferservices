using System;

namespace Lumen.Training.Libraries.DAL.Interfaces
{
    public interface ISystemContext : IDisposable
    {
        void CommitChanges();
    }
}
