

using BLOOD_DONOR_BACKEND.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BLOOD_DONOR_BACKEND.Controllers
{
    public class BloodGroupsController:ControllerBase
    {
       
        [HttpPost]
        [Route("AddBloodGroup")]
        public async Task<IActionResult> AddBloodGroup([FromBody] BloodGroupDto bgObject)
        {
            return Ok(bgObject);
        }

        [HttpPut]
        [Route("UpdateBloodGroup")]
        public async Task<IActionResult> UpdateBloodGroup(int id, [FromBody] BloodGroupDto bgObject)
        {
            return Ok(bgObject);
        }

        [HttpGet]
        [Route("GetAllBloodGroup")]
        public async Task<IActionResult> GetAllBloodGroups()
        {
            return Ok("All Groups");
        }

        [HttpGet]
        [Route("GetBloodGroupByID")]
        public async Task<IActionResult> GetBloodById()
        {
           return Ok("BG by ID");
        }

        [HttpDelete]
        [Route("DeleteBloodGroup")]

        public async Task<IActionResult> DeleteBloodGroup(int id)
        {
            return Ok("BG Deleated");
        }


    }

    
}
