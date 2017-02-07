using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using training_courses_api.Models;

namespace training_courses_api.Controllers
{
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        private ICourseRepository courseRepo;

        public CourseController(ICourseRepository _courseRepo)
        {
            courseRepo = _courseRepo;
        }
        // GET: api/course
        [HttpGet]
        public IEnumerable<Course> GetAll()
        {
            return courseRepo.GetAll();
        }

        // GET api/course/5
        [HttpGet("{id}", Name = "GetCourse")]
        public Course Get(int id)
        {
            return courseRepo.GetByID(id);
        }

        [HttpPost]
        public IActionResult Create([FromBody]Course _course)
        {
            courseRepo.Add(_course);
            return CreatedAtRoute("GetCourse", new { id = _course.id }, _course);
        }
     

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]Course _course)
        {        
            courseRepo.Update(_course);
            return new NoContentResult();
        }

       [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {       
            courseRepo.Delete(id);
            return new NoContentResult();
        }
    }
}
