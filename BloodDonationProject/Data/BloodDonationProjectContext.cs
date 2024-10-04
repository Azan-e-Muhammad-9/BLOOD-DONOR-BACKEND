using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BloodDonationProject.Models;

namespace BloodDonationProject.Data
{
    public class BloodDonationProjectContext : DbContext
    {
        public BloodDonationProjectContext (DbContextOptions<BloodDonationProjectContext> options)
            : base(options)
        {
        }

        public DbSet<BloodDonationProject.Models.Donor> Donor { get; set; } = default!;
    }
}
