using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_Service.Models;

namespace WCF_Service.DataSource
{
    public class CategoryData
    {
        public static List<Category> Categories = new List<Category>()
        {
            new Category{CategoryId = 1, Name = "Sữa bột"},
            new Category{CategoryId = 2, Name = "Sữa tươi"},
            new Category{CategoryId = 3, Name = "Sữa đặc"},
        };
    }
}
