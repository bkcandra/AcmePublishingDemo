using AcmePublishingDemo.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcmePublishingDemo.PublisherApi.Controllers
{
    [ApiController]
    [Route("api/subscriptions")]
    public class SubscriptionsController : ControllerBase
    {

        /// <summary>
        /// Retrieves a list of all subscriptions.
        /// </summary>
        /// <returns>An HTTP response with the list of subscriptions as the body.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subscription>>> GetSubscriptions()
        {
            return Ok();
        }

        /// <summary>
        /// Retrieves a specific subscription by its ID.
        /// </summary>
        /// <param name="id">The ID of the subscription to retrieve.</param>
        /// <returns>An HTTP response with the subscription as the body.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Subscription>> GetSubscription(int id)
        {
            return Ok();
        }

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="subscription">The subscription object containing the subscription information.</param>
        /// <returns>An HTTP response with the newly created subscription as the body.</returns>
        [HttpPost]
        public async Task<ActionResult<Subscription>> CreateSubscription(Subscription subscription)
        {
            return Ok();
        }

        /// <summary>
        /// Updates an existing subscription by its ID.
        /// </summary>
        /// <param name="id">The ID of the subscription to update.</param>
        /// <param name="subscription">The subscription object containing the updated subscription information.</param>
        /// <returns>An HTTP response with no content.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSubscription(int id, Subscription subscription)
        {
            return NoContent();
        }

        /// <summary>
        /// Deletes an existing subscription by its ID.
        /// </summary>
        /// <param name="id">The ID of the subscription to delete.</param>
        /// <returns>An HTTP response with no content.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubscription(int id)
        {
            return NoContent();
        }

    }


}