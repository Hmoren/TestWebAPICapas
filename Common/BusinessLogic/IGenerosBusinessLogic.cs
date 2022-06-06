using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.BusinessLogic
{
    public interface IGenerosBusinessLogic
    {
        /// <summary>
        /// Gets all the generos
        /// </summary>        
        Task<List<Genero>> LoadGenerosAsync();

        /// <summary>
        /// Create an genero
        /// </summary> 
        Task<Genero> AddGenerosAsync(Genero genero);
    }
}
