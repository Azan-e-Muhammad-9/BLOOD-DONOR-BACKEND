using BLOOD_DONOR_BACKEND.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BLOOD_DONOR_BACKEND.Controllers
{
    public class DonorController:ControllerBase
    {

        [HttpPost]
        [Route("AddDonor")]
        public async Task<IActionResult> AddDonor([FromBody] DonationsDto donObject)
        {
            return Ok(donObject);
        }

        [HttpPut]
        [Route("UpdateDonor")]
        public async Task<IActionResult> UpdateDonor(int id, [FromBody] DonationsDto donObject)
        {
            return Ok(donObject);
        }

        [HttpGet]
        [Route("GetAllDonor")]
        public async Task<IActionResult> GetAllDonor()
        {
            return Ok("All donor");
        }

        [HttpGet]
        [Route("GetDonorByID")]
        public async Task<IActionResult> GetDonorById()
        {
            return Ok("donation by ID");
        }

        [HttpDelete]
        [Route("DeleteDonor")]

        public async Task<IActionResult> DeleteDonor(int id)
        {
            return Ok("donation Deleated");
        }

    }
}
