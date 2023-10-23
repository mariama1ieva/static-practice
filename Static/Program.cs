using Static;
using Static.Controllers;

ProductController productController = new ProductController();
productController.GetCount();
productController.SearchByName();
productController.GetAll();
productController.GetAvaragePrice();
productController.OrderBydate();
productController.GetAllByCategoryName();
productController.GetAllCategoryById();

CategoryController categoryController = new CategoryController();
categoryController.GetAll();
