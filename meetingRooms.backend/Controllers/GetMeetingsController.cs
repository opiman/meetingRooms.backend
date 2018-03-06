using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace meetingRooms.backend.Controllers
{
    public class GetMeetingsController : ApiController
    {
        [Route("meetings")]
        public IHttpActionResult GetMeetings()
        {
            return Ok("Hello world");
        }
    }
}
