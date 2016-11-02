using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Ben.Controllers
{
    public class ValuesController : ApiController
    {
        // static is used so this field lives for the life of the app, rather than per request.
        private static readonly SortedDictionary<int, string> ValuesDb = new SortedDictionary<int, string>();

        // GET api/values
        public IEnumerable<dynamic> Get()
        {
            return ValuesDb
                .Select(v => new { id = v.Key, value = v.Value })
                .ToList();
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            if (!ValuesDb.ContainsKey(id))
            {
                return NotFound();
            }
            return Ok(ValuesDb[id]);
        }

        // POST api/values
        public IHttpActionResult Post([FromBody]string value)
        {
            var nextId = NextId();

            ValuesDb.Add(nextId, value);

            return Created("api/values/" + nextId, value);
        }

        private static int NextId()
        {
            if (ValuesDb.Keys.Count == 0)
            {
                return 1;
            }

            return ValuesDb.Keys.Max() + 1;
        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody]string value)
        {
            if (!ValuesDb.ContainsKey(id))
            {
                return NotFound();
            }

            ValuesDb[id] = value;

            return Ok();
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            if (!ValuesDb.ContainsKey(id))
            {
                return NotFound();
            }

            ValuesDb.Remove(id);

            return Ok();
        }
    }
}
