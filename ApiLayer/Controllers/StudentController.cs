using DataLayer.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            var students = _studentService.Get();
            return Ok(students);
        }

        [HttpGet("{id:int}")]
        public ActionResult<Student> Get(int id)
        {
            var student = _studentService.Get(id);
            return Ok(student);
        }

        [HttpPost]
        public ActionResult<Student> Post(Student student)
        {
            var result = _studentService.Add(student);
            return Ok(result);
        }

        [HttpPut]
        public ActionResult<Student> Put(Student student)
        {
            var result = _studentService.Update(student);
            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public ActionResult<Student> Delete(int id)
        {
            var result = _studentService.Delete(id);
            return Ok(result);
        }
    }
}
