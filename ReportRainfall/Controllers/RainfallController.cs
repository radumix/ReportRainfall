using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReportRainfall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RainfallController : ControllerBase
    {
        //January 13, 2024

        [HttpGet("/rainfall/id/{stationId}/readings")]
        public ActionResult<RainfallReadingResponse> GetRainfallReadings(string stationId, int count = 10)
        {

            try {
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
                    Readings = MockData.GetMeasured(count)
                };

                return Ok(response);
            } 
            catch (Exception ex) {
                var errorResponse = new ErrorResponse
                {
                    Message = "Request Invalid",
                    Detail = new List<ErrorDetail>
                    {
                        new ErrorDetail { PropertyName = "stationId", Message = ex.Message }
                    }
                };
                return BadRequest(errorResponse);
            }

            
        }

        
    }
}
