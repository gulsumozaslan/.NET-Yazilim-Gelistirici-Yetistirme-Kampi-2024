using KodlamaIoDemo.Business.Abstract;
using KodlamaIoDemo.DataAccess.Abstract;
using KodlamaIoDemo.DataAccess.Concrete;
using KodlamaIoDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemo.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal) {

            _courseDal = courseDal;
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }
    }
}
