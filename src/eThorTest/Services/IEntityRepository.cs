using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eThorTest.Data;

namespace eThorTest.Services
{
    public interface IEntityRepository
    {
        Task<EThorTestEntity> CreateAsync(EThorTestEntity entity);

        Task<IEnumerable<EThorTestEntity>> GetAllAsync();

        Task<EThorTestEntity> GetAsync(Guid id);

        Task<EThorTestEntity> UpdateAsync(EThorTestEntity entity);

        Task<bool> DeleteAsync(Guid id);
    }
}
