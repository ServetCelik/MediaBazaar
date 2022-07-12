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
    public partial class AddProduct : Form
    {
        Form1 form;
        ProductAdministrator pAdmin;
        public AddProduct(Form1 form, ProductAdministrator pAdmin)
        {
            InitializeComponent();
            this.form = form;
            this.pAdmin = pAdmin;
        }

        private void btnAddNewPrdct_Click(object sender, EventArgs e)
        {   
            string name = tbNamePrdct.Text;
            double purchasePrice;
            double sellPrice;
            string manufacturer = tbManufacturer.Text;
            string location = tbLocation.Text;
            string description = tbDescription.Text;

            if (name !=String.Empty & double.TryParse(tbPricePrdct.Text, out purchasePrice) & double.TryParse(tbSellPrice.Text, out sellPrice) & manufacturer != String.Empty & location != String.Empty & description != String.Empty)
            {
                pAdmin.NewProduct(name, purchasePrice, sellPrice, manufacturer, location, description);
                form.productFIlterTb.Clear();
                form.RefreshProducts();
                this.Close();
                form.RefreshReShelvingLisBox();
                MessageBox.Show("Succesfully Added");
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
