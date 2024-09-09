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
    public class StorageController : ControllerBase
    {
        private readonly IStorageService _storageService;
        private readonly IMapper _mapper;

        public StorageController(IStorageService storageService, IMapper mapper)
        {
            _storageService = storageService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var storages = await _storageService.GetAllAsync();
            return Ok(storages);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Add(StorageReadModel model)
        {
            var storage = await _storageService.AddAsync(model);
            return Ok(storage);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(UpdateStorageModel model)
        {
            var storage = await _storageService.UpdateAsync(model);
            return Ok(storage);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _storageService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetManager(Guid directorId)
        {
            var storage = await _storageService.GetManagerAsync(directorId);
            return Ok(storage);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetStorageId(Guid Id)
        {
            var storage = await _storageService.GetStorageIdAsync(Id);
            return Ok(storage);
        }
    }
}
