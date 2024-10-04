using System.ComponentModel.DataAnnotations.Schema;

namespace BLOOD_DONOR_BACKEND.Models
{
    public class Donations
    {
        public Guid? DonationID { get; set; }  // Nullable uniqueidentifier, Primary Key
        public Guid? DonorID { get; set; }  // Nullable uniqueidentifier, Foreign Key
        public DateTime? DonationDate { get; set; }  // Nullable date
        public Guid? BloodGroupID { get; set; }  // Nullable uniqueidentifier, Foreign Key

    }
}
