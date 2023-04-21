using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recruiting.ApplicationCore.Contracts.Services;
using Recruiting.ApplicationCore.Models;

namespace HrmRecruitingProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService candidateService;
        public CandidateController(ICandidateService candidateService)
        {
            this.candidateService = candidateService;
        }
        [HttpGet]
        public async Task<IActionResult> AllDetials()
        {
            var candidates = await candidateService.GetAllCandidates();
            return Ok(candidates);
        }
        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<CandidateResponseModel>> Details(int id)
        {
            var candidate = await candidateService.GetCandidateByIdAsync(id);
            return Ok(candidate);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CandidateRequestModel model)
        {
            
                
                
            await candidateService.AddCandidateAsync(model);
            return Ok();
                
            
            
            
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var response = new { Message = "deleted" };
            if(await candidateService.DeleteCandidateAsync(id)>0) { 
                return Ok(response);
            }
            return BadRequest();
        }
        [HttpPut]
        public async Task<IActionResult> Update(CandidateRequestModel model)
        {
            var response = new { Message = "Candidate is updated" };
            if(await candidateService.UpdateCandidateAsync(model)>0) { 
            
            return Ok(response);}
            return BadRequest();
        }
    }
}
