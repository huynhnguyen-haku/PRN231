using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.DTOs;
using Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.Models;

namespace Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.Controllers
{
    public class CategoryController : ODataController
    {
        [Authorize]
        [EnableQuery]
        public IActionResult Get()
        {
            var categoryDtos = DataSource.Categories.ToList();
            return Ok(categoryDtos);
        }

        [Authorize]
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

        [Authorize]
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

        [Authorize]
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

        [Authorize]
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
