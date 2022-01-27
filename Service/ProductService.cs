using Service.DTOs;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace Service
{
    public class ProductService
    {
        private static ProductService _instance;
        public static ProductService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProductService();
                }
                return _instance;
            }
        }
        private ProductService() { }
        public List<Product> ProductsOrderByQuantity()
        {
            using (var context = new ContextFil())
            {
                var ProductList = context.Products
                    .OrderBy(p => p.Number_In_Store)
                    .ToList();
            return ProductList;
            }
        }
        public void UpdateProductsCount(int ProductId, int NewCount)
        {
            using (var context = new ContextFil())
            {
                var changing = context.Products
                    .First(p => p.Id == ProductId)
                    ;
                changing.Number_In_Store = NewCount;
                context.SaveChanges();
            }
        }
        public List<Product> ProductsOrderByDepartment(string NameOnParameter, int InputMaxQuantity)
        {
            var result = new List<Product>();
            using (var context = new ContextFil())
            {
                int InputDepartmentID = 0;
                var department1 = context.Departments
                    .Where(d => d.Name == NameOnParameter)
                    ;
                InputDepartmentID = department1.Select(d => d.Id).FirstOrDefault();
                var departmentproduct = context.DepartmentsProducts
                    .Where(d => d.DepartmentsId == InputDepartmentID)
                    .ToList();
                foreach (var item in departmentproduct)
                {
                    var ListProducts = context.Products
                        .Where(id => id.Id == item.ProductsId)
                        .Where(p => p.Number_In_Store <= InputMaxQuantity)
                         .ToList()
                         ;
                    foreach (var product in ListProducts)
                    {
                        result.Add(new Product
                        {
                            Id = product.Id,
                            Bar_Code = product.Bar_Code,
                            Name = product.Name,
                            Number_In_Store = product.Number_In_Store,
                            List_Of_Ingredients = product.List_Of_Ingredients,
                            Exe_Date = product.Exe_Date,
                            Price = product.Price,
                        });
                    }
                }
                return result;
            }
        }
        /* The rest of the code is not included in the task */



        //public void AddProduct(Product product)
        //{
        //    using (var context = new ContextFil())
        //    {
        //        context.Products.Add(product);
        //        context.SaveChanges();
        //    }
        //}

        //public void DeleteProduct(int productnID)
        //{
        //    using (var context = new ContextFil())
        //    {
        //        var product = context.Products.First(t => t.Id == productnID);
        //        context.Products.Remove(product);
        //        context.SaveChanges();
        //    }
        //}
        //public int CountProducts()
        //{
        //    using (var context = new ContextFil())
        //    {
        //        var count = context.Products  
        //            .Count();
        //        return count;
        //    }
        //}
    }
}
