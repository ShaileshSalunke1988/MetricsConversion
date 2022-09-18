using MetricConversion.BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ConversionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        private readonly IAreaManager _conversion;

        public AreaController(IAreaManager conversion)
        {
            _conversion = conversion;
        }

        //This function is used to convert area from Imperial (Acre) into Metric (Hectare).
        [HttpGet]
        [Route("convertToMetric/{acreValue}")]
        public async  Task<IActionResult> convertToMetric(double acreValue)
        {
            var conversion = await  _conversion.GetByCode("AToH");
            return Ok(  acreValue + " Acre is equal to " + Math.Round(acreValue / Convert.ToDouble(conversion.Unit1) , 2) + " Hectare.");            
        }

        // This function is used to convert area from Metric (Hectare) into Imperial (Acre)
        [HttpGet]
        [Route("convertToImperial/{hectareValue}")]
        public async Task<IActionResult> convertToImperial(double hectareValue)
        {
            var conversion = await _conversion.GetByCode("HToA");
            return Ok(hectareValue + " Hectare is equal to " + Math.Round(hectareValue * Convert.ToDouble(conversion.Unit1), 2)+ " Acre.");           
        }
    }
}
