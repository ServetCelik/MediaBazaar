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
    public partial class ReshelvingHistory : Form
    {
        Form1 form;
        public ReshelvingHistory(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            RefreshList();
        }
        private void RefreshList()
        {
            //lbxRequestsHistory.Items.Clear();
            //foreach (var item in form.ArchivedReshelvingRequestes())
            //{
            //    lbxRequestsHistory.Items.Add(item.PendingRequestHistoryText());
            //}
            reShelvingDGVHistory.Rows.Clear();
            foreach (var item in form.ArchivedReshelvingRequestes())
            {
                reShelvingDGVHistory.Rows.Add(item.ItemName, item.Amount, item.Department, item.Specifications, item.Status);
            }
        }

        private void btnCloseReshelvingHistory_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
