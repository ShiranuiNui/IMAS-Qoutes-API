using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMAS_QOTD_API.Model;
using IMAS_QOTD_API.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace IMAS_QOTD_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class QoutesController : ControllerBase
    {
        private IReadOnlyRepository<Qoute> _repository;
        public QoutesController(IReadOnlyRepository<Qoute> repository) => this._repository = repository ??
            throw new ArgumentNullException(typeof(IReadOnlyRepository<Qoute>).ToString());
        [HttpGet]
        public ActionResult<string> Get()
        {
            var random = new Random().Next(0, _repository.Count());
            return new OkObjectResult(_repository.Get(random).QouteString);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value) { }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) { }
    }
}