using AuthenticatedApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticatedApp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class DataController : ControllerBase
{
    [HttpGet]
    public IEnumerable<DataModel> Get()
    {
        IEnumerable<DataModel> dataModels = new List<DataModel>()
        {
            new DataModel(){Label = "One Hour Ago", Date = DateTime.UtcNow.AddHours(-1)},
            new DataModel(){Label = "Now", Date= DateTime.UtcNow},
            new DataModel(){Label = "One Hour From Now", Date = DateTime.UtcNow.AddHours(1)},
            new DataModel(){Label = "This Time Tomorrow", Date = DateTime.UtcNow.AddDays(1)},
            new DataModel(){Label = "This Time Yesterday", Date= DateTime.UtcNow.AddDays(-1) }
        };

        return dataModels;

    }

}
