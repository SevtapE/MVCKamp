using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCKamp.Controllers
{
    public class StatisticsController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        public ActionResult Index()
        {
            ViewBag.NumberOfCategories = GetNumberOfCategories();
           ViewBag.NumberOfHeadingsOfCategoryYazilim = GetNumberOfHeadingsOfCategoryYazilim();
            ViewBag.NumberOfWritersWithTheNameOfA = NumberOfWritersWithTheNameOfA();
            ViewBag.CategoryWithTheMostHeadings = CategoryWithTheMostHeadings();
            ViewBag.CountDifferenceOfStatus = CountDifferenceOfStatus();
            return View();
        }
        public int GetNumberOfCategories()
        {
          return  categoryManager.GetNumberOfCategories();
         
        }

        public int GetNumberOfHeadingsOfCategoryYazilim()
        {
            return headingManager.GetNumberOfHeadingsOfCategoriesByName("Yazılım");
        }

        public int NumberOfWritersWithTheNameOfA()
        {
            return writerManager.GetNumberOfWriterByLetter("a");
        }
        public string CategoryWithTheMostHeadings()
        {
            var result = headingManager.CategoryWithTheMostHeadings();
            return result;
        }

        public int CountDifferenceOfStatus()
        {
           return categoryManager.CountDifferenceOfStatus();
        }

      

    }
}