using KodlamaIoDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemo.Business.Abstract
{
    public interface ICourseService
    {
        List<Course> GetAll();
        void Add(Course course);
    }
}
