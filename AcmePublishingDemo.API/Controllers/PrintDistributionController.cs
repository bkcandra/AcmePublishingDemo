using AcmePublishingDemo.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcmePublishingDemo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrintDistributionController : ControllerBase
    {
        /// <summary>
        /// Create a new publication that be printed, we will insert this into specific distribution company based on country code
        /// </summary>
        /// <param name="printRequest"></param>
        /// <returns></returns>
        [HttpPost("insertPublication")]
        public async Task<ActionResult> InsertPublication(Publication printRequest)
        {
            return CreatedAtAction(nameof(GetPrintRequest), new { }, printRequest);
        }

        /// <summary>
        /// Create a new print request, distribution company will pick this up and print it on specific date
        /// </summary>
        /// <param name="printRequest"></param>
        /// <returns></returns>
        [HttpPost("printrequest")]
        public async Task<ActionResult> CreatePrintRequest(PrintRequest printRequest)
        {
            return CreatedAtAction(nameof(GetPrintRequest), new { }, printRequest);
        }

        /// <summary>
        /// sent print request to customer at specific date
        /// </summary>
        /// <param name="printSentRequest"></param>
        /// <returns></returns>

        [HttpPost("deliveryrequest")]
        public async Task<ActionResult> CreatePrintSentRequest(DeliveryRequest printSentRequest)
        {

            return CreatedAtAction(nameof(GetPrintSentRequest), new { }, printSentRequest);
        }

        [HttpGet("printrequest/{id}")]
        public async Task<ActionResult> GetPrintRequest(int id)
        {

            return Ok();
        }

        [HttpGet("deliveryrequest/{id}")]
        public async Task<ActionResult> GetPrintSentRequest(int id)
        {
            return Ok();
        }
    }


}