using AcmePublishingDemo.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcmePublishingDemo.PublisherApi.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        /// <summary>
        /// Retrieves a list of all customers.
        /// </summary>
        /// <returns>An HTTP response with the list of customers as the body.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return Ok();
        }

        /// <summary>
        /// Retrieves a specific customer by their ID.
        /// </summary>
        /// <param name="id">The ID of the customer to retrieve.</param>
        /// <returns>An HTTP response with the customer as the body.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            return Ok();
        }

        /// <summary>
        /// Creates a new customer.
        /// </summary>
        /// <param name="customer">The customer object containing the customer information.</param>
        /// <returns>An HTTP response with the newly created customer as the body.</returns>
        [HttpPost]
        public async Task<ActionResult<Customer>> CreateCustomer(Customer customer)
        {
            return Ok();
        }

        /// <summary>
        /// Updates an existing customer by their ID.
        /// </summary>
        /// <param name="id">The ID of the customer to update.</param>
        /// <param name="customer">The customer object containing the updated customer information.</param>
        /// <returns>An HTTP response with no content.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, Customer customer)
        {
            return NoContent();
        }

        /// <summary>
        /// Deletes an existing customer by their ID.
        /// </summary>
        /// <param name="id">The ID of the customer to delete.</param>
        /// <returns>An HTTP response with no content.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            return NoContent();
        }

    }


}