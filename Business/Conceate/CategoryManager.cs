using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate.Repositories;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Conceate
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }
    }
}
