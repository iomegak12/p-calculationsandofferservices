using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumen.Training.Libraries.Repos.Interfaces
{
    public interface IRepository<EntityType, EntityKey> : IDisposable
    {
        IEnumerable<EntityType> GetAllEntities();
        EntityType GetEntityByKey(EntityKey entityKey);
        EntityType AddNewEntity(EntityType entityType);
    }
}
