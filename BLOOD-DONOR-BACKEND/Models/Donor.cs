using System.ComponentModel.DataAnnotations;

namespace BLOOD_DONOR_BACKEND.Models
{
    public class Donor
    {
        public Guid DonorID { get; set; }  // Primary Key, uniqueidentifier
        public string? FirstName { get; set; }  // Nullable varchar(100)
        public string? LastName { get; set; }  // Nullable varchar(100)
        public string? ContactNumber { get; set; }  // Nullable varchar(15)
        public Guid? BloodGroupID { get; set; }  // Nullable uniqueidentifier (Foreign Key)
        public DateTime? LastDonationDate { get; set; }
    }
}
