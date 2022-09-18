namespace MetricConversion.Model
{
    public partial class Conversion
    {
        public int ConversionId { get; set; }
        public string ConversionCode { get; set; }
        public decimal? Unit1 { get; set; }
        public decimal? Unit2 { get; set; }
        public string Description { get; set; }
    }
}
