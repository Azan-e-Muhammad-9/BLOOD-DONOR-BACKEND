using BLOOD_DONOR_BACKEND.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BLOOD_DONOR_BACKEND.Controllers
{
    public class DonationsController:ControllerBase
    {

        [HttpPost]
        [Route("AddDonation")]
        public async Task<IActionResult> AddDonation([FromBody] DonationsDto donObject)
        {
            return Ok(donObject);
        }

        [HttpPut]
        [Route("UpdateDonation")]
        public async Task<IActionResult> UpdateDonation(int id, [FromBody] DonationsDto donObject)
        {
            return Ok(donObject);
        }

        [HttpGet]
        [Route("GetAllDonations")]
        public async Task<IActionResult> GetAllDonations()
        {
            return Ok("All donations");
        }

        [HttpGet]
        [Route("GetDonationByID")]
        public async Task<IActionResult> GetDonationById()
        {
            return Ok("donation by ID");
        }

        [HttpDelete]
        [Route("DeleteDonation")]

        public async Task<IActionResult> DeleteDonation(int id)
        {
            return Ok("donation Deleated");
        }
    }
}
