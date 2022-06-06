using Common.BusinessLogic;
using Common.DataAccess;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business
{
    public class GenerosBusinessLogic : IGenerosBusinessLogic
    {
        private readonly IGenerosDataAccess dataAccess;

        public GenerosBusinessLogic(IGenerosDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public async Task<Genero> AddGenerosAsync(Genero genero)
        {
            await dataAccess.AddGenerosAsync(genero);
            return genero;
        }

        public async Task<List<Genero>> LoadGenerosAsync()
        {
            var generos = await dataAccess.LoadGenerosAsync();
            return generos;
        }
    }
}
