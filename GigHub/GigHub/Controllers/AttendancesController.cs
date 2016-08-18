using GigHub.Models;
using Microsoft.AspNet.Identity;
using System.Web.Http;

namespace GigHub.Controllers

{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend([FromBody] int gigId) // web api by default does not look for this in the request body it expects them to be in url. so we have to decorate with from body
        {
            var attendance = new Attendance
            {
                GigId = gigId,
                AttendeeId = User.Identity.GetUserId()
            };

            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();
        }
    }
}
