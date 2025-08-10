using Api.Models;
using Microsoft.AspNetCore.Mvc;
namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
[Consumes("application/json")]
[Produces("application/json")]
public class SubscriptionsController() : ControllerBase {

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType<Subscription>(StatusCodes.Status200OK)]
    public ActionResult<Subscription> Get(string id) => NotFound();

}
