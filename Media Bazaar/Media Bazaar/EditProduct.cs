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
    public partial class EditProduct : Form
    {

        Form1 form;
        ProductAdministrator pAdmin;
        string name;
        string price;
        string sellPrice;
        string manufacturer;
        string location;
        string description;
        int selectedId;

        public EditProduct(Form1 form, ProductAdministrator pAdmin, string name, string price, string sellPrice, string manufacturer, string location, string description,int selectedId)
        {
            InitializeComponent();
            this.form = form;
            this.pAdmin = pAdmin;
            this.name = name;
            this.price = price;
            this.sellPrice = sellPrice;
            this.manufacturer = manufacturer;
            this.location = location;
            this.description = description;
            this.selectedId = selectedId;
            tbNamePrdct.Text = this.name;
            tbPricePrdct.Text = this.price;
            tbSellPrice.Text = this.sellPrice;
            tbManufacturer.Text = this.manufacturer;
            tbLocation.Text = this.location;
            tbDescription.Text = this.description;
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            string name = tbNamePrdct.Text;
            double purchasePrice;
            double sellPrice;
            string manufacturer = tbManufacturer.Text;
            string location = tbLocation.Text;
            string description = tbDescription.Text;

            if (name != String.Empty & double.TryParse(tbPricePrdct.Text, out purchasePrice) & double.TryParse(tbSellPrice.Text, out sellPrice) & manufacturer != String.Empty & location != String.Empty & description != String.Empty)
            {
                pAdmin.EditProduct(selectedId, name, purchasePrice, sellPrice, manufacturer, location, description);
                form.productFIlterTb.Clear();
                form.RefreshProducts();
                this.Close();
                form.RefreshReShelvingLisBox();
                MessageBox.Show("Succesfully Edited");
            }
            else
            {
                MessageBox.Show("Pls fill all fields correctly");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
