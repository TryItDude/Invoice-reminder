using Invoice_reminder.Core.Entities.Clients;
using Invoice_reminder.Core.Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Invoice_reminder.WebApi.Controllers.Clients;
[Route("api/[controller]")]
[ApiController]
public class ClientsController : ControllerBase
{
    private readonly IClientRepository _clientRepository;

    public ClientsController(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    // GET: api/clients
    [HttpGet]
    public async Task<ActionResult<List<Client>>> GetClients()
    {
        var clients = await _clientRepository.GetAllAsync();
        return Ok(clients);
    }

    // GET: api/clients/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Client>> GetClientById(Guid id)
    {
        var client = await _clientRepository.GetByIdAsync(id);
        if (client == null)
        {
            return NotFound();
        }
        return Ok(client);
    }

    // POST: api/clients
    [HttpPost]
    public IActionResult CreateClient([FromBody] PostClients postClients)
    {
        if (postClients == null)
        {
            return BadRequest("Client cannot be null");
        }

        var clients = Client.Create(
            postClients.name,
            postClients.address,
            postClients.documentType,
            postClients.documentNumber,
            postClients.phoneNumber
            );

        _clientRepository.Add(clients);
        return CreatedAtAction(nameof(GetClientById), new { id = clients.Id }, clients);
    }

    // PUT: api/clients/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateClient(Guid id, [FromBody] Client client)
    {
        if (client == null || client.Id != id)
        {
            return BadRequest("Client ID mismatch");
        }

        var existingClient = _clientRepository.GetByIdAsync(id).Result;
        if (existingClient == null)
        {
            return NotFound();
        }

        _clientRepository.Update(client);
        return NoContent();
    }

    // DELETE: api/clients/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteClient(Guid id)
    {
        var client = _clientRepository.GetByIdAsync(id).Result;
        if (client == null)
        {
            return NotFound();
        }

        _clientRepository.Delete(client);
        return NoContent();
    }
}
