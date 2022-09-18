using MetricConversion.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface IConversionRepository 
    {
        Task<Conversion> GetById(int id);
        Task<Conversion> GetByCode(string code);
        Task<IEnumerable<Conversion>> GetAll();
    }
}
