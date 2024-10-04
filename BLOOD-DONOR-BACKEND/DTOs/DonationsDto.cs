namespace BLOOD_DONOR_BACKEND.DTOs
{
    public class DonationsDto
    {
     
        public Guid? DonorID { get; set; }  // Nullable uniqueidentifier, Foreign Key
        public DateTime? DonationDate { get; set; }  // Nullable date
        public Guid? BloodGroupID { get; set; }  // Nullable uniqueidentifier, Foreign Key
    }
}
