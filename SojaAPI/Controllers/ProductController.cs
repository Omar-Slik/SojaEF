using Microsoft.AspNetCore.Mvc;
using Service;
using Service.DTOs;
using SojaAPI.DTO;

namespace SojaAPI.Controllers
{
    [Route("Products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("count")]
        public List<ProductDTO> SortProductsOrderByQuantity()
        {
            var result = new List<ProductDTO>();
            foreach (var product in ProductService.Instance.ProductsOrderByQuantity())
            {
                if (product.Number_In_Store == 0)
                {
                    result.Add(new ProductDTO
                    {
                        Number_In_Store = product.Number_In_Store,
                        Name = product.Name,
                        ProductStatus = "Out Of Stock"
                    });
                }
                else if (product.Number_In_Store <= 3 && product.Number_In_Store > 0)
                {
                    result.Add(new ProductDTO
                    {
                        Number_In_Store = product.Number_In_Store,
                        Name = product.Name,
                        ProductStatus = "LimitedQuantity"
                    });
                }
                else if (product.Number_In_Store > 3)
                {
                    result.Add(new ProductDTO
                    {
                        Number_In_Store = product.Number_In_Store,
                        Name = product.Name,
                        ProductStatus = "Ok"
                    });
                }
            }
            return result;
        }
        [HttpPut("update")]
        public void UpdateProductsCount([FromBody] ProductUpdate p)
        {
            ProductService.Instance.UpdateProductsCount(p.ProductId, p.NewCount);
        }

        [HttpGet("list")]
        public List<ProductsNameDTO> ProductsOrderByDepartment(string departmentsName, int count)
        {
            var result = new List<ProductsNameDTO>();
            foreach (var product in ProductService.Instance.ProductsOrderByDepartment(departmentsName, count))
            {
                result.Add(
                    new ProductsNameDTO
                    {
                        Name = product.Name,
                    });

            };
            return result;
        }
    }
}
