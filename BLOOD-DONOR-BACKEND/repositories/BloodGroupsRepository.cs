using BLOOD_DONOR_BACKEND.DatabaseContext;
using BLOOD_DONOR_BACKEND.Interfaces;
using BLOOD_DONOR_BACKEND.Models;

namespace BLOOD_DONOR_BACKEND.repositories
{
    public class BloodGroupsRepository : IRepository<BloodGroups>
    {
        private readonly DBCONTEXT _dbContext;

        public BloodGroupsRepository(DBCONTEXT dbContext)
        {

            _dbContext = dbContext;
        }

        public Task<bool> Add(BloodGroups bg)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BloodGroups>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<BloodGroups> GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Guid id, BloodGroups entity)
        {
            throw new NotImplementedException();
        }
    }
}
