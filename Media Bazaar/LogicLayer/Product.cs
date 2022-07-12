using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Product
    {
        private int id;
        private string name;
        private double purchasePrice;
        private double sellPrice;
        private int quantity;
        private string manufacturer;
        private string storageLocation;
        private string description;
        private bool isDeleted;

        public Product()
        {
        }

        //public Product(string name, double price)
        //{
        //    this.name = name;
        //    this.price = price;
        //    this.quantity = 0;
        //}

        //public Product(int id, string name, double price, int quantity)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.price = price;
        //    this.quantity = quantity;
        //}

        public Product(string name, double purchasePrice, double sellPrice, string manufacturer, string storageLocation, string description)
        {
            this.name = name;
            this.purchasePrice = purchasePrice;
            this.sellPrice = sellPrice;
            this.quantity = 0;
            this.manufacturer = manufacturer;
            this.storageLocation = storageLocation;
            this.description = description;
        }

        public Product(int id, string name, double purchasePrice, double sellPrice, int quantity, string manufacturer, string storageLocation, string description, bool isDeleted)
        {
            this.id = id;
            this.name = name;
            this.purchasePrice = purchasePrice;
            this.sellPrice = sellPrice;
            this.quantity = quantity;
            this.manufacturer = manufacturer;
            this.storageLocation = storageLocation;
            this.description = description;
            this.isDeleted = isDeleted;
        }

        public int Id { get => id;/* set => id = value;*/ }
        public string Name { get => name; set => name = value; }
        public double PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
        public double SellPrice { get => sellPrice; set => sellPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string StorageLocation { get => storageLocation; set => storageLocation = value; }
        public string Description { get => description; set => description = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }

        //public int Id { get => id;/* set => id = value;*/ }
        //public string Name { get => name; set => name = value; }
        //public double Price { get => price; set => price = value; }
        //public int Quantity { get => quantity; set => quantity = value; }
    }
}
