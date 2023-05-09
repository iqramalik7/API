using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practiceset.Data;
using practiceset.Models;

namespace practiceset.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly Databasestu dataobj;
        public StudentController(Databasestu Dataobj)
        {
            dataobj = Dataobj;
        }
            
        [HttpPut]
        public async Task<IActionResult> PutData(int roll, string name, string department, string section)
        {
            if (ModelState.IsValid)
            {
                Student student = new Student();
                student.Roll = roll;
                student.Name = name;
                student.department = department;
                student.section = section;
                dataobj.Students.Add(student);
                await dataobj.SaveChangesAsync();
                return new JsonResult(new { message = "Data saved successfully" });
            }

            return new JsonResult(new { message = "Data not saved" });
        }

        [HttpGet]
        public async Task<ActionResult> GetData()
        {
            if (dataobj == null)
            {
                return new JsonResult(new { message = "Nothing to show" });
            }

            var students = await dataobj.Students.ToListAsync();
            return new JsonResult(students);
        }
    }
}
