using DistrolateralServer.Contacts.v1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DistrolateralServer.Contollers.v1
{
    [Route(ApiRoutes.FileController.Route)]
    [ApiController]
    public class FileController : Controller
    {
        // GET: api/<FileController>
        [HttpGet()]
        public string[] Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FileController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"value: {id}";
        }

        // POST api/<FileController>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public void Post([FromBody] string value)
        {
        }
    }
}
