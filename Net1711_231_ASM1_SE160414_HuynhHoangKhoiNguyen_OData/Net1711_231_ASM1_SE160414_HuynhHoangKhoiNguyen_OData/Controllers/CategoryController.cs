using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Net1711_231_ASM1_SE160414_HuynhHoangKhoiNguyen_OData.DTOs;
using Net1711_231_ASM1_SE160414_HuynhHoangKhoiNguyen_OData.Models;

namespace Net1711_231_ASM1_SE160414_HuynhHoangKhoiNguyen_OData.Controllers
{
    public class CategoryController : ODataController
    {
        [EnableQuery]
        public IActionResult Get()
        {
            var categoryDtos = DataSource.Categories.ToList();
            return Ok(categoryDtos);
        }

        [EnableQuery]
        public IActionResult Get([FromRoute] int key)
        {
            var category = DataSource.Categories.FirstOrDefault(c => c.CategoryId == key);

            if (category is null)
            {
                return NotFound();
            }

            var categoryDto = new CategoryDTO
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName
            };

            return Ok(categoryDto);
        }

        public IActionResult Post([FromBody] CategoryDTO categoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var category = new Category
            {
                CategoryId = categoryDto.CategoryId,
                CategoryName = categoryDto.CategoryName
            };

            DataSource.Categories.Add(category);

            return Created(category);
        }

        public IActionResult Put([FromRoute] int key, [FromBody] CategoryDTO categoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (key != categoryDto.CategoryId)
            {
                return BadRequest("Route key does not match category ID");
            }

            var existingCategory = DataSource.Categories.FirstOrDefault(c => c.CategoryId == key);

            if (existingCategory is null)
            {
                return NotFound();
            }

            existingCategory.CategoryName = categoryDto.CategoryName;

            return NoContent();
        }

        public IActionResult Delete([FromRoute] int key)
        {
            var category = DataSource.Categories.FirstOrDefault(c => c.CategoryId == key);

            if (category is null)
            {
                return NotFound();
            }

            DataSource.Categories.Remove(category); // Remove from in-memory data source

            return NoContent();
        }
    }
}
