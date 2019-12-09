using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eThorTest.Data;
using Microsoft.EntityFrameworkCore;

namespace eThorTest.Services
{
    public class EfEntityRepository : IEntityRepository
    {
        private readonly ApplicationDbContext _db;

        public EfEntityRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<EThorTestEntity> CreateAsync(EThorTestEntity entity)
        {
            var result = _db.TestEntities.Add(entity).Entity;

            await _db.SaveChangesAsync();

            return result;
        }

        public async Task<IEnumerable<EThorTestEntity>> GetAllAsync()
        {
            return await _db.TestEntities.ToListAsync();
        }

        public async Task<EThorTestEntity> GetAsync(Guid id)
        {
            return await _db.FindAsync<EThorTestEntity>(id);
        }

        public async Task<EThorTestEntity> UpdateAsync(EThorTestEntity entity)
        {
            var result = _db.TestEntities.Update(entity).Entity;

            await _db.SaveChangesAsync();

            return result;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _db.FindAsync<EThorTestEntity>(id);

            if (entity == null)
                return false;

            _db.TestEntities.Remove(entity);

            await _db.SaveChangesAsync();

            return true;
        }
    }
}
