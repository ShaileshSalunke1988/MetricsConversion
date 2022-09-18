using MetricConversion.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class ConversionRepository : IConversionRepository
    {
       private  readonly ConversionContext _ctx;

        public ConversionRepository(ConversionContext ctx)   
        {
            _ctx = ctx;
        }
        public async Task<IEnumerable<Conversion>> GetAll()
        {
            return await _ctx.Conversion.ToListAsync();
        }

        public async Task<Conversion> GetById(int id)
        {
            return await _ctx.Conversion.Where(c => c.ConversionId == id).FirstOrDefaultAsync();
        }

        public async Task<Conversion> GetByCode(string code)
        {
            return await _ctx.Conversion.Where(c => c.ConversionCode == code).FirstOrDefaultAsync();
        }
    }
}
