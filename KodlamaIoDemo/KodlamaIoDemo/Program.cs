using KodlamaIoDemo.Business.Concrete;
using KodlamaIoDemo.DataAccess.Concrete;
using KodlamaIoDemo.Entities;


Course course9 = new Course();
course9.CourseId = 1;
course9.CourseName = "Flutter";
course9.InstructorName = "Engin Demiroğ";
course9.ProgressPercentage = 100;

CourseManager courseManager = new CourseManager(new CourseDal());
courseManager.Add(course9);

List<Course> courses2 = courseManager.GetAll();

foreach (var course in courses2)
{
    Console.WriteLine(course.CourseName);
}









