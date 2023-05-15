using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileDevTraining.Web.Models;

namespace MobileDevTraining.Web.Controllers
{
    [Route("api/v1/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private TimeSpan JakartaTimeZoneSpan = new TimeSpan(7, 0, 0);
        [HttpGet]
        public ActionResult Get()
        {
            var news = new List<HomeNewsModel>
            {
                new HomeNewsModel
                {
                    HomeNewsId = 1,
                    Title = "Kurikulum mobile app development dengan react native telah diselenggarakan",
                    Timestamp = new DateTimeOffset(2023, 5, 15, 0, 0, 0, JakartaTimeZoneSpan)
                },
                new HomeNewsModel
                {
                    HomeNewsId = 1,
                    Title = "Survey training 3 + 1",
                    Timestamp = new DateTimeOffset(2023, 5, 15, 0, 0, 0, JakartaTimeZoneSpan)
                }
            };
            return Ok(news);
        }
    }
}
