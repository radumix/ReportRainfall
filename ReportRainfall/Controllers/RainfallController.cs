using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReportRainfall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RainfallController : ControllerBase
    {


        private static readonly List<RainfallReading> MockData = new List<RainfallReading>
        {
            new RainfallReading { DateMeasured = DateTime.Now.AddDays(-1), AmountMeasured = 5.7m },
            new RainfallReading { DateMeasured = DateTime.Now, AmountMeasured = 3.2m },
            // Add more mock data as needed
        };


         [HttpGet("/rainfall/id/{stationId}/readings")]
        public ActionResult<RainfallReadingResponse> GetRainfallReadings(string stationId, int count = 10)
        {
            // Simulating a call to the public rainfall API
            // In a real scenario, you would replace this with actual API calls
            // and handle errors accordingly

            if (stationId == "invalid")
            {
                var errorResponse = new ErrorResponse
                {
                    Message = "Invalid stationId",
                    Detail = new List<ErrorDetail>
                    {
                        new ErrorDetail { PropertyName = "stationId", Message = "Invalid stationId value" }
                    }
                };
                return BadRequest(errorResponse);
            }

            var response = new RainfallReadingResponse
            {
                Readings = MockData.GetRange(0, Math.Min(count, MockData.Count))
            };

            return Ok(response);
        }

        
    }
}
