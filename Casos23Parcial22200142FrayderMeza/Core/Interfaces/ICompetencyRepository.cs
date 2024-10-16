using Casos23Parcial22200142FrayderMeza.Core.Entities;

namespace Casos23Parcial22200142FrayderMeza.Core.Interfaces
{
    public interface ICompetencyRepository
    {
        Task<int> CreateCompetency(Competency competency);
        Task<bool> DeleteCompetency(int id);
        Task<IEnumerable<Competency>> GetCompetencies();
        Task<bool> UpdateCompetency(Competency competency);
    }
}