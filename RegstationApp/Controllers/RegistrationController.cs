using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegstationApp.Models;

namespace RegstationApp.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly DatabaseContext _dbContext;
        public RegistrationController(DatabaseContext dbContext)
        {

            _dbContext = dbContext;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(RegistrationModel model)
        {
            //*****
            //rest code do here
            //*****

            return View();
        }

        public JsonResult GetStates(int countryId)
        {
            var states = _dbContext.States.Where(s => s.CountryId == countryId).ToList();
            return Json(states);
        }

        public JsonResult GetCities(int stateId)
        {
            var cities = _dbContext.Cities.Where(c => c.StateId == stateId).ToList();
            return Json(cities);
        }

    }
}
