using MetricConversion.BusinessLayer;
using MetricConversion.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using System.Collections.Generic;

namespace MetricConversionUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly ITemperatureManager _TemperatureManager;
        private readonly IConversionRepository _ConversionRepository;
        private readonly ConversionContext _ctx;

        private readonly List<Conversion> _Conversion;

        public UnitTest1()
        {
            _Conversion = new List<Conversion>()
            {
                new Conversion() {ConversionId = 1,
                    ConversionCode = "FToC", Unit1 = (decimal?)32.0000, Unit2 = (decimal?)1.8000 , Description = "Fahrenheit to Celsius"},

               new Conversion()
                 {
            ConversionId = 2,
                    ConversionCode = "CToF", Unit1 = (decimal?)1.8000, Unit2 = (decimal?)32.0000 , Description = "Celsius to Fahrenheit"}
           };
            
            _ctx = new ConversionContext();
            _ConversionRepository = new ConversionRepository(_ctx);
            _TemperatureManager = new TemperatureManager(_ConversionRepository);
        }

        [TestMethod]
        public void TestMethod1()
        {            
            var testResult = _TemperatureManager.GetByCode("FToC");
            Assert.Equals(testResult.Result.Unit1, _Conversion.Find(x => x.ConversionCode == "FToC").Unit1);
        }
    }
}
