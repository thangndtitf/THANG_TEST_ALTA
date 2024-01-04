using System.Net.Http.Headers;
using THANG_TEST.Models.Weather;
using THANG_TEST.Models.Weather.Weather;

namespace THANG_TEST.BLL
{
    public class WeatherBLL
    {
        static HttpClient client = new HttpClient();

        private String uri = "http://api.openweathermap.org/data/2.5/group?id=1580578,1581129,1581297,1581188,1587923&units=metric&appid=91b7466cc755db1a94caf6d86a9c788a";

        public async Task<ResponeWeather> getResponeAsysn(string path)
        {
            ResponeWeather respWeather = null;
            HttpResponseMessage respone = await client.GetAsync(path);
            if(respone.IsSuccessStatusCode)
            {
                respWeather = await respone.Content.ReadAsAsync<ResponeWeather>();
            }
            return respWeather;
        }

        public async Task<ResultDataWeather> getResultWeather()
        {
            ResultDataWeather resultWeather = new ResultDataWeather();
            try
            {
               
                ResponeWeather respWeather = await getResponeAsysn(uri);
                List<CityWeather> cityWeatherList = new List<CityWeather>();
                List<Weat> listWeat = respWeather.list;
                foreach (Weat weat in listWeat)
                {
                    CityWeather cityWeather = new CityWeather();
                    cityWeather.cityId = weat.id;
                    cityWeather.cityName = weat.name;

                    cityWeather.weatherMain = weat.weather.First<Weathers>().main;
                    cityWeather.weatherDescription = weat.weather.First<Weathers>().description;
                    cityWeather.weatherIcon = weat.weather.First<Weathers>().icon;
                    cityWeather.mainTemp = weat.main.temp;
                    cityWeather.mainHumidity = weat.main.humidity;
                    cityWeatherList.Add(cityWeather);
                }
                resultWeather.data = cityWeatherList;
                resultWeather.message = " Current weather information of cities";
                resultWeather.statusCode = 200;
            }
            catch (Exception ex)
            {

                resultWeather.data = null;
                resultWeather.message = ex.ToString();
                resultWeather.statusCode = 500;
            }

            return resultWeather;
        }


    }
}
