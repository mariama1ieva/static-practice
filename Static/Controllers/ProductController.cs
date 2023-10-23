using Domain.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Controllers
{
   
    public  class ProductController
    {
        private readonly ProductService _productService;
        public ProductController()
        {
            _productService = new ProductService();
        }

        public void GetCount()
        {
            int count = _productService.GetCount();
            Console.WriteLine(count);
        }
        public void SearchByName()
        {
            Console.WriteLine("Add search text");
            string searchText=Console.ReadLine();
            var result = _productService.Search(searchText);
            foreach ( var item in result )
            {
               string data =$"{  item.Name },{item.price},{item.id},{item.Category.Name}";
                Console.WriteLine(data);
            }

        }

        public void GetAll()
        {
            
            var result = _productService.GetAll();
            foreach (var item in result)
            {
                string data = $"{item.Name},{item.price},{item.id},{item.Category.Name}";
                Console.WriteLine(data);
            }
        }

        public void GetAvaragePrice()
        {
            var avrprice = _productService.GetAvaragePrice();
            Console.WriteLine(avrprice);
        }

        public void OrderBydate()
        {
            var result = _productService.OrderBydate();
            foreach (var item in result)
            {
                string data = $"{item.Name},{item.price},{item.id},{item.Category.Name}";
                Console.WriteLine(data);
            }
        }
        public void GetAllByCategoryName()
        {
            var result = _productService.GetAllByCategory();
            foreach (var item in result)
            {
                string data = $"{item.Name},{item.price},{item.id},{item.Category.Name}";
                Console.WriteLine(data);
            }
        }

        public void GetAllCategoryById()
        {
            var result = _productService.GetAllCategoryById();
            foreach (var item in result)
            {
                string data = $"{item.Name},{item.price},{item.id},{item.Category.Name}";
                Console.WriteLine(data);
            }
        }
    }
}
