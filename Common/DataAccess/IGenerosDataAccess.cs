using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.DataAccess
{
    public interface IGenerosDataAccess
    {
        /// <summary>
        /// Gets all the generos
        /// </summary>        
        Task<List<Genero>> LoadGenerosAsync();

        Task<Genero> AddGenerosAsync(Genero genero);
    }
}
