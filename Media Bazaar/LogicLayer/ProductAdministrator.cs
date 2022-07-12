using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DatabaseLayer;

namespace LogicLayer
{
    public class ProductAdministrator
    {
        List<Product> products = new List<Product>();
        List<Product> deletedProducts = new List<Product>();
        List<ProductDTO> productDTOs = new List<ProductDTO>();
        ProductDatabase dbProduct = new ProductDatabase();
        /// <summary>
        /// Get a product DTO and map it to a product
        /// </summary>
        /// <param name="productDTO"></param>
        /// <returns></returns>
        public Product MapperObject(ProductDTO productDTO)
        {
            Product product = new Product(productDTO.Id, productDTO.Name, productDTO.PurchasePrice,productDTO.SellPrice, productDTO.Quantity,productDTO.Manufacturer,productDTO.StorageLocation, productDTO.Description, productDTO.IsDeleted);
            return product;
        }
        /// <summary>
        /// This method map all the product DTO list to product and then add it either products list or deletedProducts list
        /// </summary>
        /// <param name="dTOs"></param>
        public void MapperList(List<ProductDTO> dTOs)
        {
            products.Clear();
            deletedProducts.Clear();
            foreach (var item in dTOs)
            {
                if (item.IsDeleted==false)
                {
                    products.Add(MapperObject(item));
                }
                else
                {
                    deletedProducts.Add(MapperObject(item));
                }
                
            }
        }
        /// <summary>
        /// This method get all the list from db and feed local lists with this data
        /// </summary>
        public void UpdateLists()
        {
            dbProduct.getAllProducts(productDTOs);
            MapperList(productDTOs);
        }
        public void NewProduct(string name, double purchasePrice, double sellPrice, string manufacturer, string storageLocation, string description)
        {
            dbProduct.CreateProduct(name,purchasePrice,sellPrice,manufacturer,storageLocation,description);
        }

        
        /// <summary>
        /// Edits given product 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="purchasePrice"></param>
        /// <param name="sellPrice"></param>
        /// <param name="manufacturer"></param>
        /// <param name="storageLocation"></param>
        /// <param name="description"></param>
        public void EditProduct(int id, string name, double purchasePrice, double sellPrice, string manufacturer, string storageLocation, string description)
        {
            dbProduct.UpdateProduct(id, name, purchasePrice, sellPrice, manufacturer, storageLocation, description);
        }

        public void IncreaseQuantity(int id, int quantity)
        {
            dbProduct.IncreaseProduct(id, quantity);
        }

        public void DecreaseQuantity(int id, int quantity)
        {
            dbProduct.DecreaseProduct(id, quantity);
        }
        /// <summary>
        /// Change the bool value of an product to 1
        /// </summary>
        /// <param name="id"></param>
        public void DeleteProduct(int id)
        {
            dbProduct.DeleteProduct(id);
        }
        /// <summary>
        /// returns local products list
        /// </summary>
        /// <returns></returns>
        public List<Product> GetListOfProducts()
        {
            return products;
        }
        /// <summary>
        /// returns local deletedProducts list
        /// </summary>
        /// <returns></returns>
        public List<Product> GetListOfDeletedProducts()
        {
            return deletedProducts;
        }
       
    }
}
