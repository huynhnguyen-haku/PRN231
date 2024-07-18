using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.DTOs;
using Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.Models;

namespace Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.Controllers
{
    public class ProductController : ODataController
    {
        [EnableQuery]
        public IActionResult Get()
        {
            var productDtos = DataSource.Products.ToList();
            return Ok(productDtos);
        }

        [EnableQuery]
        public IActionResult Get([FromRoute] int key)
        {
            var product = DataSource.Products.FirstOrDefault(p => p.ProductId == key);
            if (product is null)
            {
                return NotFound();
            }
            var productDto = new ProductDTO
            {
                ProductId = product.ProductId,
                AccountId = product.AccountId,
                CategoryId = product.CategoryId,
                ProductName = product.ProductName,
                Price = product.Price,
                QuantityInStock = product.QuantityInStock,
                Description = product.Description,
                Status = product.Status,
                CreatedDate = product.CreatedDate,
                UpdatedDate = product.UpdatedDate,
                TotalRating = product.TotalRating
            };
            return Ok(productDto);
        }

        public IActionResult Post([FromBody] ProductDTO productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var product = new Product
            {
                ProductId = productDto.ProductId,
                AccountId = productDto.AccountId,
                CategoryId = productDto.CategoryId,
                ProductName = productDto.ProductName,
                Price = productDto.Price,
                QuantityInStock = productDto.QuantityInStock,
                Description = productDto.Description,
                Status = productDto.Status,
                CreatedDate = productDto.CreatedDate,
                UpdatedDate = productDto.UpdatedDate,
                TotalRating = productDto.TotalRating
            };
            DataSource.Products.Add(product);
            return Created(product);
        }

        public IActionResult Put([FromRoute] int key, [FromBody] ProductDTO productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (key != productDto.ProductId)
            {
                return BadRequest("Route key does not match product ID");
            }
            var existingProduct = DataSource.Products.FirstOrDefault(p => p.ProductId == key);
            if (existingProduct is null)
            {
                return NotFound();
            }
            existingProduct.AccountId = productDto.AccountId;
            existingProduct.CategoryId = productDto.CategoryId;
            existingProduct.ProductName = productDto.ProductName;
            existingProduct.Price = productDto.Price;
            existingProduct.QuantityInStock = productDto.QuantityInStock;
            existingProduct.Description = productDto.Description;
            existingProduct.Status = productDto.Status;
            existingProduct.UpdatedDate = DateTime.Now;
            existingProduct.TotalRating = productDto.TotalRating;
            return Updated(existingProduct);
        }
        public IActionResult Delete([FromRoute] int key)
        {
            var product = DataSource.Products.FirstOrDefault(p => p.ProductId == key);
            if (product is null)
            {
                return NotFound();
            }
            DataSource.Products.Remove(product);
            return NoContent();
        }

    }
}
