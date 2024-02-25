using CSharpWork_3.DataAccess.Abstracts;
using CSharpWork_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWork_3.DataAccess.Concretes;

public class CategoryDal: ICategoryDal
{
    List<Category> _categories;
    public CategoryDal()
    {
        _categories = new List<Category>
        {

        new Category{Id=1,CategoryName="Yazılım Geliştirme"},
        new Category{Id=2,CategoryName="Sıfırdan Eğitim"}
        };
    }

    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Delete(Category category)
    {
        _categories.Remove(category);
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public void Update(Category category)
    {
        Console.WriteLine("Kategori güncelleme işlemi burada gerekleşecek.");
    }

}
