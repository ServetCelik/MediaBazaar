using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Bazaar
{
    public partial class DeletedItems : Form
    {        
        ProductAdministrator pAdmin;
        
        public DeletedItems(ProductAdministrator pAdmin)
        {
            InitializeComponent();           
            this.pAdmin = pAdmin;            
            RefreshProducts();
        }
        

        public void RefreshProducts()
        {
            pAdmin.UpdateLists();
            dgvDeletedProducts.Rows.Clear();

            foreach (var item in partOfList(deletedProductFIlterTb.Text))
            {
                dgvDeletedProducts.Rows.Add(item.Name, item.PurchasePrice, item.SellPrice, item.Manufacturer, item.StorageLocation, item.Description);
            }

        }

        public List<Product> partOfList(string partOfName)
        {
            List<Product> partialList = new List<Product>();
            var fullList = pAdmin.GetListOfDeletedProducts();

            foreach (var item in fullList)
            {
                if (item.Name.Contains(partOfName))
                {
                    partialList.Add(item);
                }
            }
            return partialList;
        }

        private void btnRefreshDeletedProducts_Click(object sender, EventArgs e)
        {
            RefreshProducts();
        }
    }
}
