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
    public partial class C07_Promotion : Form
    {
        CMART1Entities1 db = new CMART1Entities1();
        C07_PromotionBUS bus = new C07_PromotionBUS();
        Promotion promotion = new Promotion();
        validation a = new validation();
        string image;
        int i = 0;
        int t = 0;
        public C07_Promotion(string name)
        {
            InitializeComponent();
            label1.Text = name;
            importManagementToolStripMenuItem.Visible = false;
            billToolStripMenuItem.Visible = false;
            loadList();
            this.tabList.TabIndex = 0;
            this.tabAdd.TabIndex = 1;
            btnCancel.Text ="Clear";
        }
        public void loadList()
        {
            list.DataSource = bus.loadPromotion();
            list.Columns[0].Visible = false;
            list.Columns[7].Visible = false;
        }
        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            C08_Product product = new C08_Product(label1.Text);
            product.ShowDialog();
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                string message = null;
                if (!a.Required(txtID))
                {
                    message += "Name is a required field\n";
                }
                else if (!a.checkNumbertype(txtID.Text))
                {
                    message += "ID product is not right";
                }
                else if (!a.checkNumbertype(txtPrice.Text))
                {
                    message += "Price is not right";
                }
                else if (!a.Required(txtPrice))
                { message += "txtPrice is a required field\n"; }
                else
                {
                    
                    if (bus.addPromotion(int.Parse(txtID.Text), float.Parse(txtPrice.Text), image, dateTimeStart.Value, dateTimeEnd.Value, txtContent.Text))
                    {
                        message += "Add New Promotion successfully\n";
                        loadList();
                        tabControl1.SelectedIndex = 0;
                    }
                    else message += "Add New Promotion fail";

                }
                if (message == null)
                    MessageBox.Show("Success");
                else MessageBox.Show(message);
            }
            if (i == 1)
            {
                string message = null;
                if (!a.Required(txtID))
                    message += "Name is a required field\n";
                else if (!a.checkNumbertype(txtID.Text))
                {
                    message += "ID product is not right";
                }
                else if (!a.checkNumbertype(txtPrice.Text))
                {
                    message += "Price is not right";
                }
                else
                {

                        string id = (string)list.SelectedRows[0].Cells[0].Value;
                        if (bus.editPromotion(id, int.Parse(txtID.Text), txtPrice.Text, image, dateTimeStart.Value, dateTimeEnd.Value, txtContent.Text))
                        {
                            message += "Update Promotion successfully\n";
                            loadList();
                            this.tabAdd.Text = "Add";
                            tabControl1.SelectedIndex = 0;
                            btnEdit.Enabled = true;
                    }
                    else message += "Update Promotion fail";
                }
                if (message == null)
                {
                    i = 0;
                    MessageBox.Show("Success");
                }
                else MessageBox.Show(message);
            }
        }

        private void promotionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void priceHistoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            C06_PriceHistory pricehis = new C06_PriceHistory(label1.Text);
            pricehis.ShowDialog();
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
            list.DataSource = bus.searchPromotion(txtSearch.Text);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            t++;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                img.Image = new Bitmap(open.FileName);
                image = "hinhanhPromotion"+t+".jpg";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count == 1)
            {
                i = 1;
                CMART1Entities1 db = new CMART1Entities1();
                string id = (string)list.SelectedRows[0].Cells[0].Value;
                promotion = db.Promotions.Single(st => st.IDPromotion.Equals(id));
                txtID.Text = promotion.IDProduct.ToString();
                txtPrice.Text = promotion.Price.ToString();
                image = promotion.Image;
                img.ImageLocation = image;
                txtContent.Text = promotion.Contents;
                this.tabAdd.Text = "Edit";
                btnEdit.Enabled = false;
                btnCancel.Text = "Cancel";
                tabControl1.SelectedIndex = 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = (string)list.SelectedRows[0].Cells[0].Value;
            if (bus.deletePromotion(id, list))
            {
                MessageBox.Show("Delete Promotion successfully! ");
                loadList();
            }
            else MessageBox.Show("Choose Promotion in list ");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtID.Text = "";
                txtPrice.Text = "";
                txtContent.Text = "";
                img.Image = null;
            }
            if (i==1)
            {
                txtID.Text = "";
                txtPrice.Text = "";
                txtContent.Text = "";
                img.Image = null;
                image = null;
                i = 0;
                this.tabAdd.Text = "Add";
                btnCancel.Text = "Clear";
                btnEdit.Enabled = true;
                tabControl1.SelectedIndex = 0;
            }
        }
    }
}
