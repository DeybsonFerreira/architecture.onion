using Microsoft.AspNetCore.Mvc;
using onion.Domain.Entities;
using onion.Domain.Interfaces.Repositories;

namespace onion.API.Controllers;

[ApiController]
[Route("api/person")]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;
    private readonly IPersonRepository _personRepository;

    public PersonController(ILogger<PersonController> logger, IPersonRepository personRepository)
    {
        _logger = logger;
        // _personRepository = new Infrastructure.Dapper.Repositories.PersonRepository(); //usado pelo dapper
        // _personRepository = new Infrastructure.EFCore.Repositories.PersonRepository(); //usado pela EF
        _personRepository = personRepository; //usado pela Injeção dependencia
    }

    [HttpGet()]
    [Route("{personId:guid}")]
    public async Task<IActionResult> Get(Guid personId)
    {
        _logger.LogInformation($"PersonId Searched : {personId}");
        Person person = await _personRepository.GetAsync(personId);
        return Ok(person);
    }
}
