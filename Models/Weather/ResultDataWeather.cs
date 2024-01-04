namespace THANG_TEST.Models.Weather.Weather
{
    public class ResultDataWeather
    {
        public List<CityWeather> data { get; set; }
        public string message { get; set; }
        public int statusCode { get; set; }
    }
}
