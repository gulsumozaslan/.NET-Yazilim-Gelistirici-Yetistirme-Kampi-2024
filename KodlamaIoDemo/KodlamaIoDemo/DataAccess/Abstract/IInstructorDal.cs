using KodlamaIoDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemo.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        List<Instructor> GetInstructor();
    }
}
