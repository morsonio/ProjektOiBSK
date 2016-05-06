using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PortableSteam;
using WebApplication1.PortableSteamExtension;

namespace WebApplication1.Controllers
{
    public class SteamAppsController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            SteamWebAPI.SetGlobalKey("0");
            var list = SteamWebAPI.General().ISteamApps().GetAppList().GetResponse();
            string list2 = ""; // TODO: stworzyć listę, która pobiera te pierdoły w taki sposób w jaki pobierane są w tej fajoskiej bibliotece, np. PortableSteamExtension.GetAppDetails().GetResponse();
            return list.Data.Apps.Select(x => x.AppID.ToString() + " - " + x.Name.ToString());
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
