using KodlamaIoDemo.DataAccess.Abstract;
using KodlamaIoDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemo.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;

        public InstructorDal()
        {
            instructors = new List<Instructor>();
            
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public List<Instructor> GetInstructor()
        {
            return instructors;
        }
    }
}
