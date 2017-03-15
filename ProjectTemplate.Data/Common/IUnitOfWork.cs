using System;

namespace ProjectTemplate.Data.Common
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Save all pending changes
        /// </summary>
        /// <returns>The number of objects in an Added, Modified, or Deleted state</returns>
        int Commit();
    }
}
