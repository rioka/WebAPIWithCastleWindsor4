using System.Collections.Generic;
using System.Web.Http;

namespace WebAPIWithCastleWindsor4.Api.Controllers
{
  public class ValuesController : ApiController
  {
    // GET api/<controller>
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }
  }
}