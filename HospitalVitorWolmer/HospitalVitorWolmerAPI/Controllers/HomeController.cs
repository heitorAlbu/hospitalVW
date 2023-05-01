using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalVitorWolmerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {


        [HttpGet ("teste")]
        public string teste() 
        {
            return "!?";
        
        }

        [HttpGet("testeabc")]
        public string testeabc()
        {
            return "Novo endpoint GET com rota testeabc!";
        }


    }
}
