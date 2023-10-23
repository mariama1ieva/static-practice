using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IProduct
    {
        int GetCount();
        Product[] Search(string searchText);
        Product[] GetALl();
        Decimal GetAvaragePrice();
        Product[] OrderByDate();
        Product[] CategoryName(string categoryname);

        Product[] GetAllByCategoryId(int id);   


    }
}
