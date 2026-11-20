using ConceptAPI.Data;
using Microsoft.AspNetCore.Mvc;
using ConceptAPI.Models.WorldWideImpModels;

namespace ConceptAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        private readonly WideWorldImportersDbContext dBContext;
        public CountryController(WideWorldImportersDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        [HttpGet]
        public IActionResult GetAllCountrys()
        {
            try
            {
                List<CountryMaster> countryMasters = new List<CountryMaster>();
                countryMasters = dBContext.CountryMasters.ToList();
                return Ok(countryMasters);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
