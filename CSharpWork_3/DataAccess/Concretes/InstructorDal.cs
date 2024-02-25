using CSharpWork_3.DataAccess.Abstracts;
using CSharpWork_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWork_3.DataAccess.Concretes
{
    public class InstructorDal:IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            Instructor instructor1 = new();
            instructor1.Id = 1;
            instructor1.InstructorFirstName = "Engin";
            instructor1.InstructorLastName = "DEMİROĞ";

            Instructor instructor2 = new();
            instructor2.Id = 2;
            instructor2.InstructorFirstName = "Halit Enes";
            instructor2.InstructorLastName = "KALAYCI";

            _instructors = new List<Instructor> { instructor1, instructor2 };

        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            Console.WriteLine("Eğitmen güncelleme işlemi burada gerekleşecek.");
        }
    }
}
