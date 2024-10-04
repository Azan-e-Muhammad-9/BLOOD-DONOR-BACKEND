using System.ComponentModel.DataAnnotations;

namespace BLOOD_DONOR_BACKEND.Models
{
    public class BloodGroups
    {
        public Guid BloodGroupID { get; set; }  // Primary Key, uniqueidentifier
        public string? BloodGroupName { get; set; }  // Nullable varchar(10)

      
    }
}
