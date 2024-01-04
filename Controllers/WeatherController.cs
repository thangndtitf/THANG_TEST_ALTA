using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using THANG_TEST.BLL;
using THANG_TEST.Models.Weather.Weather;

namespace THANG_TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        WeatherBLL weatherBLL = new WeatherBLL();
        /*
                [HttpGet]

               public async Task<ResponeWeather> getResponeWeather()
               {
                   String uri = "http://api.openweathermap.org/data/2.5/group?id=1580578,1581129,1581297,1581188,1587923&units=metric&appid=91b7466cc755db1a94caf6d86a9c788a";
                   ResponeWeather result = await weatherBLL.getResponeAsysn(uri);
                   return result;
               }
         */
        [HttpGet]
        [Route("/getWeather")]
        public async Task<ResultDataWeather> getWeather()
        {
            ResultDataWeather resultData = await weatherBLL.getResultWeather();
            return resultData;
        }
    }
}
