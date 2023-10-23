using Domain.Data;
using Domain.Models;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService : IProduct
    {
        private readonly AppDbContext _context;
        public ProductService()
        {
            _context = new AppDbContext();
        }

        public Product[] GetAllByCategoryId(int id)
        {
            return _context.Products().Where(x=>x.Id == id).ToArray();
        }

       

        public int GetCount()
        {
            var products= _context.Products;
            return products.Length;
        }

       
        Product[] IProduct.CategoryName(string categoryname)
        {
           return _context.Products().Where(m=>m.Category.Name==categoryname).ToArray();
        }

        Product[] IProduct.GetALl()
        {
            var products=_context.Products;
            int productcount = product.Length;
            decimal sumofprice=products.Sum(x=>x.Price);
            return sumofprice/productcount;
        }


        Product[] IProduct.Search(string searchText)
        {
            return _context.Products().Where(x => x.Name.Trim().ToLower().Contains(searchText.Trim().ToLower())).ToArray();
        }
    }
}
