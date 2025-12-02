using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    // To use this controller we have use routing like this https://localhost:portnumber/api/student. This will point to this controller.
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly string[] students = new string[] { "Dheepan", "Yamuna", "Arumugam" };

        //In this get is used to get all the details from the data or resource using this GET: https://localhost:portnumber/api/student. This will help to retreive all the data. 
        [HttpGet]
        public IActionResult GetStudentDetail()
        {
            // Here OK is the successfully return data to the client application.
            return Ok(students);
        }
    }
}
