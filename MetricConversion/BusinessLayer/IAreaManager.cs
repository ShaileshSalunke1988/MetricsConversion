using MetricConversion.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MetricConversion.BusinessLayer
{
    public interface IAreaManager
    {
        Task<Conversion> GetById(int id);
        Task<Conversion> GetByCode(string code);
        Task<IEnumerable<Conversion>> GetAll();
    }
}
