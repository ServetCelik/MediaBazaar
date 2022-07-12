using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Bazaar
{
    public class Reshelving
    {
        private int id;
        private string itemName;
        private int amount;
        private string department;
        private string specifications;
        private AppStatus status;

        public Reshelving(string itemname, int amount, string department, string specifications, AppStatus status)
        {
            this.itemName = itemname;
            this.amount = amount;
            this.department = department;
            this.specifications = specifications;
            this.status = AppStatus.PENDING;
        }

        public Reshelving(int id, string itemname, int amount, string department, string specifications, AppStatus status)
        {
            this.id = id;
            this.itemName = itemname;
            this.amount = amount;
            this.department = department;
            this.specifications = specifications;
            this.status = status;
        }

        public int Id { get { return id; } }
        public string ItemName { get { return this.itemName; } }
        public int Amount { get { return this.amount; } }
        public string Department { get { return this.department; } }
        public string Specifications { get { return this.specifications; } }
        public AppStatus Status { get => status; set => status = value; }

        public string PendingRequestText()
        {
            return $"Item Name:{itemName} Amount:{amount} Department:{department} Specifications:{specifications}, Status:{status}";
            //return $"Item Name: {itemName} Amount: {amount} Department: {department} Specifications: {specifications}";
        }
        public string PendingRequestHistoryText()
        {
            return $"Item Name:{itemName} Amount:{amount} Department:{department} Specifications:{specifications}, Status:{status}";
            //return $"Item Name: {itemName} Amount: {amount} Department: {department} Specifications: {specifications}";
        }
    }
}
