using CSharpWork_3.DataAccess.Abstracts;
using CSharpWork_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWork_3.DataAccess.Concretes;

public class CourseDal:ICourseDal
{
    List<Course> _courses;
    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "Senior Yazılım";
        course1.Description = ".Net";
        course1.InstructorId = 1;
        course1.CategoryId = 2;
        course1.Price = 10;


        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Yazılım Geliştirici";
        course2.Description = "Angular";
        course2.InstructorId = 2;
        course1.CategoryId = 2;
        course2.Price = 20;


        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Python Geliştirici";
        course3.Description = "Python";
        course3.InstructorId = 1;
        course1.CategoryId = 1;
        course3.Price = 30;

        _courses  = new List<Course> {course1,course2,course3 };

    }
    public List<Course> GetAll()
    {
        //db işlemleri
        return _courses;
    }

    public void Add(Course course)
    {
        _courses.Add(course);     
    }

    public void Delete(Course course)
    {
        _courses.Remove(course);
    }

    public void Update(Course course)
    {
        Console.WriteLine("Kurs güncelleme işlemi burada gerekleşecek.");
    }
}
