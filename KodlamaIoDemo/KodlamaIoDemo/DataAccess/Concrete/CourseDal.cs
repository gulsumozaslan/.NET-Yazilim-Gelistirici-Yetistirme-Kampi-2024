using KodlamaIoDemo.DataAccess.Abstract;
using KodlamaIoDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemo.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal() {

            Course course1 = new Course();
            course1.CourseId = 1;
            course1.CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)";
            course1.ProgressPercentage = 100;
            course1.InstructorName = "Engin Demiroğ";

            Course course2 = new Course();
            course2.CourseId = 1;
            course2.CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course2.ProgressPercentage = 100;
            course2.InstructorName = "Engin Demiroğ";

            Course course3 = new Course();
            course3.CourseId = 1;
            course3.CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium";
            course3.ProgressPercentage = 0;
            course3.InstructorName = "Halit Kalaycı";

            Course course4 = new Course();
            course4.CourseId = 1;
            course4.CourseName = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA";
            course4.ProgressPercentage = 50;
            course4.InstructorName = "Engin Demiroğ";


            Course course5 = new Course();
            course5.CourseId = 1;
            course5.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
            course5.ProgressPercentage = 70;
            course5.InstructorName = "Engin Demiroğ";


            Course course6 = new Course();
            course6.CourseId = 1;
            course6.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT))";
            course6.ProgressPercentage = 45;
            course6.InstructorName = "Engin Demiroğ";


            Course course7 = new Course();
            course7.CourseId = 1;
            course7.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)";
            course7.ProgressPercentage = 100;
            course7.InstructorName = "Engin Demiroğ";


            Course course8 = new Course();
            course8.CourseId = 1;
            course8.CourseName = "Programlamaya Giriş için Temel Kurs";
            course8.ProgressPercentage = 50;
            course8.InstructorName = "Engin Demiroğ";

            courses = new List<Course> { course1, course2, course3, course4, course5, course6, course7, course8 };

        }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Remove(Course course)
        {
            courses.Remove(course);
        }
    }
}
