using MetricConversion.BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ConversionApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemperatureController : ControllerBase
    {
        private readonly ITemperatureManager _conversion;

        public TemperatureController(ITemperatureManager conversion)
        {
            _conversion = conversion;
        }

        // This function is used to convert temperature from Imperial (Fahrenheit) into Metric (Celsius).  
        [HttpGet]
        [Route("ConvertToMetric/{fahrenheitValue}")]
        public async Task<IActionResult> ConvertToMetric(double fahrenheitValue)
        {
            var conversion = await _conversion.GetByCode("FToC");
            return Ok(fahrenheitValue + " Fahrenheit is equal to " + Math.Round((fahrenheitValue - Convert.ToDouble(conversion.Unit1)) / Convert.ToDouble(conversion.Unit2), 2)+ " Celsius");           
        }


        // This function is used to convert temperature from Metric (Celsius) into Imperial (Fahrenheit).
        [HttpGet]
        [Route("ConvertToImperial/{celsiusValue}")]
        public async Task<IActionResult> ConvertToImperial(double celsiusValue)
        {
            var conversion = await _conversion.GetByCode("CToF");
            return Ok(celsiusValue + " Celsius is equal to " +Math.Round((celsiusValue * Convert.ToDouble(conversion.Unit1)) + Convert.ToDouble(conversion.Unit2), 2) + " Fahrenheit.");            
        }
    }
}
