using BLOOD_DONOR_BACKEND.DatabaseContext;
using BLOOD_DONOR_BACKEND.Interfaces;
using BLOOD_DONOR_BACKEND.Models;

namespace BLOOD_DONOR_BACKEND.repositories
{
    public class DonorRepository : IRepository<Donor>
    {
        private readonly DBCONTEXT _dbContext;

        public DonorRepository(DBCONTEXT dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<bool> Add(Donor entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Donor>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Donor> GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Guid id, Donor entity)
        {
            throw new NotImplementedException();
        }
    }
}
