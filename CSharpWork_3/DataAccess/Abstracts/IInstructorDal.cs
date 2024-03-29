﻿using CSharpWork_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWork_3.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        void Add(Instructor instructor);
        void Delete(Instructor instructor);
        void Update(Instructor instructor);

    }
}
