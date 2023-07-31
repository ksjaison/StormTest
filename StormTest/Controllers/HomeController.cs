using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StormTest.StormTest.BusinessService;

namespace StormTest.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IStudentDet _studentDet;

        public HomeController(IStudentDet studentDet)
        {
            _studentDet = studentDet;
        }
        [HttpGet]
        public async Task<IActionResult> getName(int studentId)
        {
            studentId = 2;
            //StudentDetailService studentDetailService = new StudentDetailService();
            var studentdetails = _studentDet.getName(studentId);
            return Ok(studentdetails);
        }
    }
}
