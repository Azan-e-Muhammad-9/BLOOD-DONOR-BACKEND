using BLOOD_DONOR_BACKEND.DatabaseContext;
using BLOOD_DONOR_BACKEND.Interfaces;
using BLOOD_DONOR_BACKEND.Models;

namespace BLOOD_DONOR_BACKEND.repositories
{
    public class DonationsRepository : IRepository<Donations>
    {

        private readonly DBCONTEXT _dbContext;


        DonationsRepository(DBCONTEXT dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<bool> Add(Donations entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Donations>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Donations> GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Guid id, Donations entity)
        {
            throw new NotImplementedException();
        }
    }
}
