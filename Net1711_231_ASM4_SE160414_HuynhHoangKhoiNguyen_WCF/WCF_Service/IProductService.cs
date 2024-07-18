using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_Service.Models;

namespace WCF_Service
{
    [ServiceContract]
    public interface IProductService
    {
        #region Category
        [OperationContract]
        List<Category> GetCategories();

        [OperationContract]
        Category GetCategoryById(int categoryId);

        [OperationContract]
        bool UpdaCategory(Category category);

        [OperationContract]
        bool AddCategory(Category category);

        [OperationContract]
        bool DeleteCategory(int categoryId);
        #endregion

        #region Product
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        Product GetProductById(int productId);

        [OperationContract]
        bool UpdateProduct(Product product);

        [OperationContract]
        bool AddProduct(Product product);

        [OperationContract]
        bool DeleteProduct(int productId);
        #endregion
    }

}
