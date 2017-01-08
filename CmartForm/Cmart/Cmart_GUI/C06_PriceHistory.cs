using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cmart.Cmart_GUI;
using Cmart.BUS;
namespace Cmart.Cmart_GUI
{
    public partial class C06_PriceHistory : Form
    {
        validation a = new validation();
        C06_PriceHistoryBUS bus = new C06_PriceHistoryBUS();
        int i = 0;
        int id;
        public C06_PriceHistory(string name)
        {
            InitializeComponent();
            label1.Text = name;
            importManagementToolStripMenuItem.Visible = false;
            billToolStripMenuItem.Visible = false;
            this.tabList.TabIndex = 0;
            this.tabAdd.TabIndex = 1;
            loadList();
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (i==0)
            {
                string message = null;
                if (!a.Required(txtID))
                {
                    message += "ID is a required field\n";
                }
                else if (!a.checkNumbertype(txtID.Text))
                {
                    message += "ID product is not right";
                }
                else if (!a.Required(txtPrice))
                {
                    message += "Price is a required field\n";
                }
                else if (!a.checkNumber(txtPrice.Text.ToString()))
                {
                    message += "Price fills numbers\n";
                }
                else if (!a.RangeMoney(1000, float.Parse(txtPrice.Text.ToString())))
                {
                    message += "Price begins 1000vnd\n";
                }
                else if (a.compareDate(dateTime.Value, DateTime.Now))
                {
                    message += "Available Day is equal or less than now\n";
                }
                else if (bus.addPriceHistory(txtID.Text, txtPrice.Text, dateTime.Value))
                {
                    loadList();
                    tabControl1.SelectedIndex = 0;
                }
                else message += "update priceHistory fail";
                if (message == null)
                {
                    i = 0;
                    MessageBox.Show("Success");
                }
                else MessageBox.Show(message);
            }
            if (i == 1)
            {
                DateTime date = (DateTime)list.SelectedRows[0].Cells["Date"].Value;
                string message = null;
                if (!a.Required(txtID))
                {
                    message += "ID is a required field\n";
                }
                if (!a.Required(txtPrice))
                {
                    message += "Price is a required field\n";
                }
                else if (!a.checkNumber(txtPrice.Text.ToString()))
                {
                    message += "Price fills numbers\n";
                }
                else if (!a.RangeMoney(1000, float.Parse(txtPrice.Text.ToString())))
                {
                    message += "Price begins 1000vnd\n";
                }
                else if (a.compareDate(dateTime.Value, DateTime.Now))
                {
                    message += "Available Day is equal or less than now\n";
                }

                else if (bus.editPriceHT(id,date, txtPrice.Text,dateTime.Value))
                {
                    loadList();
                    tabAdd.Text = "Add";
                    btnCancel.Text = "Clear";
                    i = 0;
                    tabControl1.SelectedIndex = 0;
                    txtID.Enabled = true;
                    txtID.Text = "";
                    txtPrice.Text = "";
                    dateTime.Value = DateTime.Now;
                } else message +="update priceHistory fail";
                    if (message == null)
                    {
                        i = 0;
                        MessageBox.Show("Success");
                    }
                    else MessageBox.Show(message);
                }
        }

        public void loadList()
        {
            list.DataSource=bus.loadListPriceHistory();
            list.Columns[3].Visible = false;
        }
        private void productToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            C08_Product product = new C08_Product(label1.Text);
            product.ShowDialog();
            this.Close();
        }

        private void promotionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            C07_Promotion promote = new C07_Promotion(label1.Text);
            promote.ShowDialog();
            this.Close();
        }

        private void headImportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void branchImportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
   
        }

        private void billToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
   
        }

        private void statisticToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            C02_Statistic statistic = new C02_Statistic(label1.Text);
            statistic.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            C01_Login a = new C01_Login();
            a.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != null)
            {
                list.DataSource = bus.searchListHistory(txtSearch.Text);
            }
            if (txtSearch.Text=="")
            {
                loadList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)list.SelectedRows[0].Cells[0].Value;
            DateTime date = (DateTime)list.SelectedRows[0].Cells["Date"].Value;
            if (bus.deletePriceHT(id,date))
            {
                MessageBox.Show("Delete Price success");
                loadList();
            }else MessageBox.Show("Delete Price fail");

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count == 1)
            {
                i = 1;
                tabAdd.Text = "Edit";
                this.id = (int)list.SelectedRows[0].Cells[0].Value;
                string price = list.SelectedRows[0].Cells["Price"].Value.ToString();
                DateTime date = (DateTime)list.SelectedRows[0].Cells["Date"].Value;
                CMART1Entities1 db = new CMART1Entities1();
                txtID.Text = id.ToString();
                txtPrice.Text = price;
                dateTime.Value = date;
                btnCancel.Text = "Cancel";
                tabControl1.SelectedIndex = 1;
                txtID.Enabled = false;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (i==0)
            {
                txtID.Text = null;
                txtPrice.Text = null;
                dateTime.Value = DateTime.Now;
            }
            if (i==1)
            {
                i = 0;
                txtID.Text = null;
                txtPrice.Text = null;
                dateTime.Value = DateTime.Now;
                tabControl1.SelectedIndex = 0;
                btnCancel.Text ="Clear";
                tabAdd.Text = "Add";
                txtID.Enabled = true;
            }
        }
    }
}
