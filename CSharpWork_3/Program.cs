// See https://aka.ms/new-console-template for more information
using CSharpWork_3.Business;
using CSharpWork_3.DataAccess.Concretes;
using CSharpWork_3.Entities;




Course course1 = new Course();
course1.Id = 1;
course1.Name = "Senior Yazılım";
course1.Description = ".Net";
course1.InstructorId = 1;
course1.CategoryId = 1;
course1.Price = 10;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "Yazılım Geliştirici";
course2.Description = "Angular";
course2.InstructorId = 2;
course2.CategoryId = 1;
course2.Price = 20;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python Geliştirici";
course3.Description = "Python";
course3.InstructorId = 1;
course3.CategoryId = 2;
course3.Price = 30;

Course[] courses = {course1, course2, course3};


CategoryManager categoryManager = new(new CategoryDal());

List<Category> categories = categoryManager.GetAll();
for (int i = 0; i < categories.Count; i++)
{
    Console.WriteLine("Kategori adı: " + categories[i].CategoryName);
}

Console.WriteLine("-----------------------------");



CourseManager courseManager = new(new CourseDal());

List<Course> courses1 = courseManager.GetAll();
for (int i = 0; i < courses1.Count; i++)
{
    Console.WriteLine("Kurs Adı: " + courses[i].Name);
    Console.WriteLine("Kurs Ücreti: " + courses[i].Price);
}
courseManager.Delete(courses[1]);
courseManager.Update(courses[2]);

Console.WriteLine("--------------------------");




InstructorManager instructorManager = new(new InstructorDal());

List<Instructor> instructors = instructorManager.GetAll();
for (int i = 0; i < instructors.Count; i++)
{
    Console.WriteLine("Eğitmen: " + instructors[i].InstructorFirstName + " " + instructors[i].InstructorLastName);

}

