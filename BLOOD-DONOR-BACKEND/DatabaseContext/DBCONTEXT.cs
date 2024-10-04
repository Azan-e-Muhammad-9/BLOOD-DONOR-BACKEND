using BLOOD_DONOR_BACKEND.Models;
using Microsoft.EntityFrameworkCore;
using System.Data; 
 

namespace BLOOD_DONOR_BACKEND.DatabaseContext
{
    public class DBCONTEXT : DbContext
    {
        public DBCONTEXT(DbContextOptions<DBCONTEXT> option) : base(option)
        {

        }
        // ALL MODELS HERE!
        public DbSet<Donations> Donations { get; set; }
        public DbSet<Donor> Donor { get; set; }
        public DbSet<BloodGroups> BloodGroup { get; set; }
    }
}




 