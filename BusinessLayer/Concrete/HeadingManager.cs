using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public string CategoryWithTheMostHeadings()
        {
            var result = _headingDal.List().Max(x => x.Category.CategoryName);
            return result;
        }

        public int GetNumberOfHeadingsOfCategoriesByName(string categoryName)
        {
            var result = _headingDal.List(x => x.Category.CategoryName == categoryName).Count;
            return result;
        }

        public List<Heading> ListHeadings()
        {
           return _headingDal.List();
        }
    }
}
