using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace datingappcore.Controllers {
    [Route ("api/[controller]/[action]")]
    [ApiController]
    public class DummyController : ControllerBase {

        [HttpGet]
        public ActionResult<string> GetdataValues () {
            return "Success";
        }
    }
}