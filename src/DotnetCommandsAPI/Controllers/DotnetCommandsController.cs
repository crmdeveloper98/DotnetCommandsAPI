using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using src.DotnetCommandsAPI.Data;
using src.DotnetCommandsAPI.Models;

namespace src.DotnetCommandsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DotnetCommandsController : ControllerBase
    {

        private readonly IDotnetCommandsAPIRepository _repository;

        public DotnetCommandsController(IDotnetCommandsAPIRepository repository)
        {
            _repository = repository;
        }     

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<DotnetCommand>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DotnetCommand> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            if (commandItem == null)
            {
                return NotFound();
            }
            return Ok(commandItem);
        }
    }
}