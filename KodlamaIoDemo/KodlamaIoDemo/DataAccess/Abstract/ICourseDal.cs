using KodlamaIoDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemo.DataAccess.Abstract
{
    public interface ICourseDal
    {
        void Add(Course course);
        List<Course> GetAll();
        void Remove(Course course);

    }
}
