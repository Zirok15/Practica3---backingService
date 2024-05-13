using Microsoft.AspNetCore.Mvc;
using UPB.BusinessLogic.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientCodeController : ControllerBase
    {
        CodeCreator.Models.CodeCreator codeCreator;
        public PatientCodeController()
        {
            codeCreator = new();
        }

        // GET api/<PatientCodeController>/5
        [HttpGet]
        public string Get([FromQuery]Patient patient)
        {
            return codeCreator.CreateCode(patient.name, patient.lastName, patient.ci);
        }
    }
}
