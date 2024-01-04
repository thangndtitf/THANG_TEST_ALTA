namespace THANG_TEST.Models.Weather.Weather
{
    public class CityWeather
    {
        public int cityId { get; set; }
        public string cityName { get; set; }
        public string weatherMain { get; set; }
        public string weatherDescription { get; set; }
        public string weatherIcon { get; set; }
        public double mainTemp { get; set; }
        public int mainHumidity { get; set; }
    }
}
