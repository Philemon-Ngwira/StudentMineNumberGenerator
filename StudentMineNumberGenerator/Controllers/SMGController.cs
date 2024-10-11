using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentMineNumberGeneratorDomain.Repositories;

namespace StudentMineNumberGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMGController : ControllerBase
    {
        private readonly GenericRepository _genericRepository
    }
}
