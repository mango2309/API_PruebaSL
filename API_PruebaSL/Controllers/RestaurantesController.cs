using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using API_PruebaSL.Models;
using API_PruebaSL.Repositories;

namespace API_PruebaSL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantesController : ControllerBase
    {
        [HttpGet]
        [Route("InformacionRestaurante")]
        public ActionResult DevuelveRestaurante(int id)
        {
            try
            {
                RestauranteRepository repo = new RestauranteRepository();
                var restaurantes = repo.DevuelveRestaurantes();
                var info_restaurante = restaurantes.Find(x => x.Id == id);

                return Ok(info_restaurante);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            
        }

        [HttpGet]
        [Route("ListadoRestaurantes")]
        public List<Restaurante> DevuelveListadoRestaurantes()
        {
            RestauranteRepository repo = new RestauranteRepository();
            return repo.DevuelveRestaurantes();
        }
    }
}
