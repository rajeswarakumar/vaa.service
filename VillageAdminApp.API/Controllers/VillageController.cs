using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VillageAdminApp.API.Infrastructure.Repositories;
using VillageAdminApp.API.Model;

namespace VillageAdminApp.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class VillageController : ControllerBase
    {
        private readonly IVillageRepository _villageRepository;
        private readonly ILogger<VillageController> _logger;

        public VillageController(
        ILogger<VillageController> logger,
        IVillageRepository repository)
        {
            _logger = logger;
            _villageRepository = repository;
        }

        // add a get method to return all users
        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Getting all users");
            List<Village> villages = new List<Village>();
            villages.Add(new Village() { 
                Id = 1, 
                VillageName = "Madambakkam", 
                CreatedBy = 1, 
                CreatedOn = DateTime.Now, 
                ModifiedBy = 1, 
                ModifiedOn = DateTime.Now, 
                Status = true 
            });
            return Ok(villages);
            //return Ok(_villageRepository.GetAll());
        }

        // add a get method to return a user by id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            _logger.LogInformation("Getting user by id");
            return Ok(_villageRepository.GetVillageById(id));
        }
    }
}
