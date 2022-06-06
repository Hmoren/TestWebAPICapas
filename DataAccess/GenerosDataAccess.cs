using Common.DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GenerosDataAccess : IGenerosDataAccess
    {
        private readonly ApplicationDbContext context;

        public GenerosDataAccess(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Genero> AddGenerosAsync(Genero genero)
        {
            this.context.Add(genero);
            var response = await this.context.SaveChangesAsync();
            return genero;
        }

        /// <inheritdoc/>   
        public async Task<List<Genero>> LoadGenerosAsync()
        {
            var generos = await this.context.Generos.ToListAsync();
            return generos;
        }        
    }
}
