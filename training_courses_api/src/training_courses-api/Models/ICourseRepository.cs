using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace training_courses_api.Models
{
    public interface ICourseRepository
    {
        void Add(Course course);
        IEnumerable<Course> GetAll();
        Course GetByID(int id);
        void Delete(int id);
        void Update(Course course);
    }
}
