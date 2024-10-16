using Casos23Parcial22200142FrayderMeza.Core.Entities;
using Casos23Parcial22200142FrayderMeza.Core.Interfaces;
using Casos23Parcial22200142FrayderMeza.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Casos23Parcial22200142FrayderMeza.Infraestructure.Repositories
{
    public class CompetencyRepository : ICompetencyRepository
    {
        private readonly Parcial20240222200142Context _parcial20240222200142Context1;

        public CompetencyRepository(Parcial20240222200142Context parcial20240222200142Context)
        {
            _parcial20240222200142Context1 = parcial20240222200142Context;

        }
        //create competency
        public async Task<int> CreateCompetency(Competency competency)
        {
            await _parcial20240222200142Context1.Competency.AddAsync(competency);
            int rows = await _parcial20240222200142Context1.SaveChangesAsync();

            return (rows > 0) ? competency.Id : -1;

        }
        //Actualizar competency
        public async Task<Boolean> UpdateCompetency(Competency competency)
        {
            _parcial20240222200142Context1.Competency.Update(competency);
            int rowsm = await _parcial20240222200142Context1.SaveChangesAsync();
            return rowsm > 0;
        }

        //delete competency
        public async Task<Boolean> DeleteCompetency(int id)
        {
            var competency = await _parcial20240222200142Context1
                .Competency
                .FirstOrDefaultAsync(c => c.Id == id);
            if (competency == null) return false;

            _parcial20240222200142Context1.Competency.Remove(competency);
            int rows = await _parcial20240222200142Context1.SaveChangesAsync();
            return rows > 0;


        }

        //get all
        public async Task<IEnumerable<Competency>> GetCompetencies()
        {
            var competencies = await _parcial20240222200142Context1.Competency.ToListAsync();
            return competencies;
        }










    }
}
