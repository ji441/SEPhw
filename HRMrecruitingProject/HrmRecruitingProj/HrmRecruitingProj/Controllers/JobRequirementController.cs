using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recruiting.ApplicationCore.Contracts.Services;
using Recruiting.ApplicationCore.Models;

namespace HrmRecruitingProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobRequirementController : ControllerBase
    {
        private readonly IJobRequirementService jobService;
        public JobRequirementController(IJobRequirementService jobService)
        {
            this.jobService = jobService;
        }
        [HttpGet]
        public async Task<IActionResult> AllDetails()
        {
            var jobrequiremnts = await jobService.GetAllJobRequirements();
            return Ok(jobrequiremnts);
        }
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> Details(int id)
        {
            var jobrequirement = await jobService.GetJobRequirementByIdAsync(id);
            return Ok(jobrequirement);
        }
        [HttpPost]
        public async Task<IActionResult> Create(JobRequirementRequestModel model)
        {
            if(model != null)
            {
                await jobService.AddJobRequirementAsync(model);
                return Ok(model);
            }
            return BadRequest();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(JobRequirementRequestModel model)
        {
            if(model != null)
            {
                await jobService.DeleteJobRequirementAsync(model.Id);
                return Ok();
            }
            return BadRequest();
        }
        [HttpPut]
        public async Task<IActionResult> Update(JobRequirementRequestModel model)
        {
            if(model != null)
            {
                await jobService.UpdateJobRequirementAsync(model);
                return Ok();
            }
            return BadRequest();
        }

    }
}
