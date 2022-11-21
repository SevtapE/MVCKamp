using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAddBL(Category p)
        {
            _categoryDal.Insert(p);
        }

        public void CategoryDelete(Category p)
        {
            _categoryDal.Delete(p);
        }

        public void CategoryUpdate(Category p)
        {
            _categoryDal.Update(p);
        }

        public int CountDifferenceOfStatus()
        {
            int a = _categoryDal.List(x => x.CategoryStatus == true).Count;
            int b = _categoryDal.List(x => x.CategoryStatus == false).Count;
           return Math.Abs(a - b);
        }

        public Category GetByID(int id)
        {
           return _categoryDal.Get(x => x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public int GetNumberOfCategories()
        {
            return _categoryDal.List().Count;
           
        }

    }
}
