using Microsoft.AspNetCore.Mvc;
using RealEstateAPI;
using RealEstateAPI.Model;

namespace RealEstateAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        Listing _listing;
        public Listings _listings;


        // GET: api/<ListingsController>
        [HttpGet("GetListings")]
        public Listings Get()
        {
            return _listings;
        }

        // POST api/<ListingsController>
        [HttpPost("PostListing")]
        public void Post([FromBody] string value)
        {
            _listing = new Listing { Id = "2", Title = value, Price = 300, Description = value };
            _listings.addListing(_listing);
        }

        // DELETE api/<ListingsController>/5
        [HttpDelete("DeleteListing/{id}")]
        public void Delete(string id)
        {
            _listings.removeListing(id);
        }
    }
}
