using MetricConversion.Model;
using Repository;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MetricConversion.BusinessLayer
{
    public class LengthManager : ILengthManager
    {
        private readonly IConversionRepository _conversion;

        public LengthManager(IConversionRepository conversion)
        {
            _conversion = conversion;
        }
        public async Task<IEnumerable<Conversion>> GetAll()
        {
            return await _conversion.GetAll();
        }

        public async Task<Conversion> GetByCode(string code)
        {
            return await _conversion.GetByCode(code);
        }

        public async Task<Conversion> GetById(int id)
        {
            return await _conversion.GetById(id);
        }
    }
}
