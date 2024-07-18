using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_Service.DataSource;
using WCF_Service.Models;

namespace WCF_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in both code and config file together.
    public class ProductService : IProductService
    {
        public bool AddCategory(Category category)
        {
            try
            {
                Category cate = CategoryData.Categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);
                if (cate == null)
                {
                    CategoryData.Categories.Add(category);
                }
                else
                {
                    throw new Exception("Category already exists");
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddProduct(Product product)
        {
            try
            {
                Product prod = ProductData.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
                if (prod == null)
                {
                    ProductData.Products.Add(product);
                }
                else
                {
                    throw new Exception("Product already exists");
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteCategory(int categoryId)
        {
            try
            {
                Category cate = CategoryData.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
                if (cate != null)
                {
                    CategoryData.Categories.Remove(cate);
                }
                else
                {
                    throw new Exception("Category not found");
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteProduct(int productId)
        {
            try
            {
                Product prod = ProductData.Products.FirstOrDefault(p => p.ProductId == productId);
                if (prod != null)
                {
                    ProductData.Products.Remove(prod);
                }
                else
                {
                    throw new Exception("Product not found");
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Category> GetCategories()
        {
            return CategoryData.Categories.ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return CategoryData.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
        }

        public Product GetProductById(int productId)
        {
            return ProductData.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public List<Product> GetProducts()
        {
            return ProductData.Products.ToList();
        }

        public bool UpdaCategory(Category category)
        {
            try
            {
                Category cate = CategoryData.Categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);
                if (cate != null)
                {
                    cate.Name = category.Name;
                }
                else
                {
                    throw new Exception("Category not found");
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                Product prod = ProductData.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
                if (prod != null)
                {
                    prod.CategoryId = product.CategoryId;
                    prod.Name = product.Name;
                    prod.Price = product.Price;
                    prod.Quantity = product.Quantity;
                    prod.Description = product.Description;
                    prod.ImageUrl = product.ImageUrl;
                    prod.TotalRating = product.TotalRating;
                    prod.CreatedAt = product.CreatedAt;
                    prod.UpdatedAt = product.UpdatedAt;
                    prod.Status = product.Status;
                }
                else
                {
                    throw new Exception("Product not found");
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
