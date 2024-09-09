using Microsoft.AspNetCore.Mvc;
using DataLayer.Entities;
using Epic5_Task1.BLL.Models.GetEntityModels;
using Epic5_Task1.BLL.Services.Interfaces;
using Epic5_Task1.DataLayer.Data.Infrastucture;
using Epic5_Task1.DataLayer.Data.Repositories.Interfaces;
using AutoMapper;
using Epic5_Task1.BLL.Services.Realization;

namespace Epic5_Task1.Epic6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployerController : ControllerBase
    {
        private readonly IEmployerService _employerService;
        private readonly IMapper _mapper;

        public EmployerController(IEmployerService employerService, IMapper mapper)
        {
            _employerService = employerService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var employers = await _employerService.GetAllAsync();
            return Ok(employers);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Add(EmployerReadModel model)
        {
            var employer = await _employerService.AddAsync(model);
            return Ok(employer);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(UpdateEmployerModel model)
        {
            var employer = await _employerService.UpdateAsync(model);
            return Ok(employer);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _employerService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetEmployer(Guid storageId)
        {
            var employer = await _employerService.GetEmployerAsync(storageId);
            return Ok(employer);
        }
    }

   
}
