using HospitalVitorWolmerAPI.Contexto;
using HospitalVitorWolmerAPI.Dominio;
using HospitalVitorWolmerAPI.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalVitorWolmerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly DBContexto _DBContext;
        public HomeController(DBContexto DBContext)
        {
            _DBContext = DBContext;
        }

        [HttpGet("obterMedicos")]
        public List<Medico> ObterMedicos()
        {
            return  _DBContext.Medicos.ToList();
        }


    }
}
