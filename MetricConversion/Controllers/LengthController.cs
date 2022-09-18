using MetricConversion.BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ConversionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LengthController : ControllerBase
    {
        private readonly ILengthManager _conversion;

        public LengthController(ILengthManager conversion)
        {
            _conversion = conversion;
        }

        // This function is used to convert length from Imperial (Mile) into Metric (Kilometer).
        [HttpGet]
        [Route("convertToMetric/{mileValue}")]
        public async Task<IActionResult> convertToMetric(double mileValue)
        {
            var conversion =await  _conversion.GetByCode("MToK");
            return Ok( mileValue + " Mile is equal to " + Math.Round(mileValue * Convert.ToDouble(conversion.Unit1), 2) + " Kilometers.");          
        }

        //This function is used to convert length from Metric (Kilometer) into Imperial (Mile).
        [HttpGet]
        [Route("convertToImperial/{kilometerValue}")]
        public async Task<IActionResult>  convertToImperial(double kilometerValue)
        {
            var conversion =await  _conversion.GetByCode("KToM");
            return Ok(kilometerValue + " Kilometer is equal to  " + Math.Round(kilometerValue / Convert.ToDouble(conversion.Unit1), 2) + " Miles.");           
        }
    }
}
