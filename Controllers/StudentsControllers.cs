using TestApplication.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TestApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class StudentsController : ControllerBase
    {
        public static List<Students> GetStudents()
        {
            List<Students> students = new List<Students>();
            students.Add(new Students() { Id = 23734, Name = "Lucas T", Appartement = "C.17" });
            students.Add(new Students() { Id = 23732, Name = "Louis R", Appartement = "C.18" });
            students.Add(new Students() { Id = 23750, Name = "Valentin P", Appartement = "C.17"});
            students.Add(new Students() { Id = 23707, Name = "Alexis D", Appartement = "C.18"});
            students.Add(new Students() { Id = 23731, Name = "Loïc S", Appartement = "D.15" });
            return students;
        }
        [HttpGet]
        public IEnumerable<Students> GetStudents_List()
        {
            return GetStudents();
        }
         [HttpGet("{id}")]
        public ActionResult<Students> GetStudents_ById(int id)
        {
            var students = GetStudents().Find(x => x.Id == id);
            if(students != null)
            {
                return students;
            }
            else
            {
                return NotFound();           
            }
            
        }
    }

}