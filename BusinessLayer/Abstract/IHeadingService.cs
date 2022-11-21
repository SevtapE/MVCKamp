﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IHeadingService
    {
       List<Heading> ListHeadings();
        int GetNumberOfHeadingsOfCategoriesByName(string categoryName);
        string CategoryWithTheMostHeadings();
    }
}
