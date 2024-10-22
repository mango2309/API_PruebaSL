using API_PruebaSL.Models;

namespace API_PruebaSL.Repositories
{
    public class RestauranteRepository
    {
        public List<Restaurante> DevuelveRestaurantes()
        {
            List<Restaurante> restaurantes = new List<Restaurante>();
            Restaurante restaurante = new Restaurante
            {
                Id = 1,
                Nombre = "McDonadls",
                CostoComercial = 100000,
                Direccion = "Orellana",
                AceptaMascotas = false
            };
            Restaurante restaurante2 = new Restaurante
            {
                Id = 1,
                Nombre = "Burguer King",
                CostoComercial = 100000,
                Direccion = "Orellana",
                AceptaMascotas = false
            };

            restaurantes.Add(restaurante);
            restaurantes.Add(restaurante2);
            return restaurantes;

        }
        public Restaurante DevuelveRestaurante()
        {
            Restaurante restaurante = new Restaurante()
            {
                Id = 1,
                Nombre = "McDonadls",
                CostoComercial = 100000,
                Direccion = "Orellana",
                AceptaMascotas = false
            };
            return restaurante;
        }
    }
}
