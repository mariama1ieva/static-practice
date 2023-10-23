using Service;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class CategoryController
    {
        private readonly ICategory _category;
        public CategoryController()
        {
            _category=new CategoryService();
        }

        public void GetAll()
        {
            var categories=_category.GetAll();
           
            foreach (var item in categories)
            {
                string data = $"{item.Category.Name}";
                Console.WriteLine(data);
            }
        }
    }
}
