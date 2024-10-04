namespace BLOOD_DONOR_BACKEND.DTOs
{
    public class DonorDto
    {
      
        public string? FirstName { get; set; }  // Nullable varchar(100)
        public string? LastName { get; set; }  // Nullable varchar(100)
        public string? ContactNumber { get; set; }  // Nullable varchar(15)
        public Guid? BloodGroupID { get; set; }  // Nullable uniqueidentifier (Foreign Key)
        public DateTime? LastDonationDate { get; set; }
    }
}
