using Microsoft.AspNetCore.Mvc;
using Prometheus;

namespace App.Controllers
{
    [ApiController]
    [Route("/")]
    public class RootController : ControllerBase
    {
        private static readonly Counter Hits = Metrics.CreateCounter("hits", "Number of hits");

        [HttpGet]
        public string Get()
        {
            Hits.Inc();
            return "Hello, World! v2";
        }
    }
}
