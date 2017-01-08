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
    public partial class C04_HeadImport : Form
    {
        validation a = new validation();
        C04_HeadImportBUS bus = new C04_HeadImportBUS();
        string IDAcc;
        int i = 0;
        double Total = 0;
        string id;
        string[] idRe ;
        public C04_HeadImport(string name,string IDAcc)
        {
            InitializeComponent();
            this.IDAcc = IDAcc;
            lblName.Text = name;
            importManagementToolStripMenuItem.Visible = false;
            billToolStripMenuItem.Visible = false;
            categoToolStripMenuItem.Visible = false;
            statisticToolStripMenuItem.Visible = false;
            list2.Columns.Add("IDRequest", "IDRequest");
            list2.Columns.Add("IDProduct", "IDProduct");
            list2.Columns.Add("ProductName", "ProductName");
            list2.Columns.Add("Quantity", "Quantity");
            list2.Columns.Add("Price", "Price");
            list2.Columns.Add("Expiration", "Expriration");
            list2.Columns.Add("Status", "Status");
            this.tabList.TabIndex = 0;
            this.tabAdd.TabIndex = 1;
            btnCancel.Text = "Clear";
            loadList();
            loadIDRe();
            txtIDRequest.DisplayMemberChanged += TxtIDRequest_DisplayMemberChanged;
            txtIDRequest.TextChanged += TxtIDRequest_TextChanged;
        }

        private void TxtIDRequest_TextChanged(object sender, EventArgs e)
        {
            a: if (txtIDProduct.Items.Count>0)
            {
                txtIDProduct.Items.RemoveAt(0);
                goto a;
            }
            loadIDPro();
        }

        private void TxtIDRequest_DisplayMemberChanged(object sender, EventArgs e)
        {

        }

        public void loadIDRe()
        {
            CMART1Entities1 db = new CMART1Entities1();
            List<requestImport> re = db.requestImports.ToList();
            requestImport h = null;
            foreach (requestImport ri in re)
            {
                txtIDRequest.Items.Add(ri.IDRequestImport);
                h = ri;
            }
            txtIDRequest.DropDownStyle = ComboBoxStyle.DropDownList;
            txtIDRequest.DisplayMember = h.IDRequestImport;
        }
        public void loadIDPro()
        {
            CMART1Entities1 db = new CMART1Entities1();
            List<requestImport_List> re = db.requestImport_List.Where(st=>st.IDRequestImport.Equals(txtIDRequest.Text)).ToList();
            foreach (requestImport_List idpro in re)
            {
                txtIDProduct.Items.Add(idpro.IDProduct);
            }

        }
        public void loadList()
        {
            list.DataSource = bus.loadListHeadImport();
            list.Columns[7].Visible = false;
            list.Columns[5].Visible = false;
            list.Columns[6].Visible = false;
        }
        public void addHead()
        {
            if (bus.checkexistIDreandIDPro(txtIDRequest.Text, txtIDProduct.Text))
            {
                bool flag = false;
                for (int i = 0; i < list2.Rows.Count - 1; i++)
                {
                    if (txtIDProduct.Text == list2.Rows[i].Cells[1].Value.ToString())
                    {
                        flag = true;
                        list2.Rows[i].Cells[0].Value = txtIDRequest.Text;
                        list2.Rows[i].Cells[1].Value = txtIDProduct.Text;
                        bus.addProductList(int.Parse(txtIDProduct.Text));
                        list2.Rows[i].Cells[2].Value = bus.getNamePro();
                        list2.Rows[i].Cells[3].Value = txtQuantity.Text;
                        list2.Rows[i].Cells[4].Value = txtPrice.Text;
                        list2.Rows[i].Cells[5].Value = dateTime.Value;
                        list2.Rows[i].Cells[6].Value = txtStatus.Text;
                        break;
                    }
                }
                if (flag == false)
                {
                    if (bus.addProductList(int.Parse(txtIDProduct.Text)))
                    {
                        list2.Rows.Add(txtIDRequest.Text, txtIDProduct.Text, bus.getNamePro(), txtQuantity.Text, txtPrice.Text, dateTime.Value, txtStatus.Text);
                    }
                    else MessageBox.Show("IDProduct is not existed in Request");
                }
            }
            else MessageBox.Show("IDRequest or IDPro is not right");
            calDetail();
        }
        public void calDetail()
        {
            if (list2.Rows.Count > 0)
            {
                Total = 0;
                for (int i = 0; i < list2.Rows.Count - 1; i++)
                {
                    Total += double.Parse(list2.Rows[i].Cells[4].Value.ToString());
                }
                lblTotalAmount.Text = "" + Total;
            }
        }
        public void removeAllHI()
        {
            list2.Rows.Clear();
            list2.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void productToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        
        }

        private void promotionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void priceHistoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
          
        }

        private void headImportToolStripMenuItem_Click(object sender, EventArgs e)
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
     
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            C01_Login a = new C01_Login();
            a.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bus.deleteHeadImport((string)list.SelectedRows[0].Cells[0].Value))
            {
                loadList();
                MessageBox.Show("Delete HeadImport successfully");
            }
            else MessageBox.Show("Delete HeadImport fail");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            list.DataSource=bus.searchHeadImport(txtSearch.Text);
            list.Columns[7].Visible = false;
            list.Columns[5].Visible = false;
            list.Columns[6].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = null;
            if (txtIDRequest.Text ==null)
            {
                message += "You should choose idRequest\n";
            }
            else if (txtIDProduct.Text == null)
            {
                message += "You should fill or choose idProduct\n";
            }
            else if (!a.Required(txtQuantity))
            {
                message += "Quantity is a required field\n";
            }
            else if (!a.Required(txtPrice))
            {
                message += "Price is a required field\n";
            }
            else if (!a.checkNumbertype(txtQuantity.Text))
            {
                message += "Quantity is not right";
            }
            else if (!a.checkNumbertype(txtPrice.Text))
            {
                message += "Price is not right";
            }
            else if (!a.checkNumbertype(txtIDProduct.Text))
            {
                message += "ID is not right";
            }
            else if (!a.Range(1, 1, int.Parse(txtQuantity.Text.ToString())))
            {
                message += "Quantity is more than zero\n";
            }
            else
            {
                addHead();
                txtIDProduct.Text = "";
                txtQuantity.Text = "";
                dateTime.Value = DateTime.Now;
                txtPrice.Text = "";
                txtStatus.Text = "";
            }
            if (message != null)
            {
                MessageBox.Show(message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (this.list2.SelectedRows.Count > 0)
            {
                list2.Rows.RemoveAt(this.list2.SelectedRows[0].Index);
                calDetail();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int[] idproduct = new int[list2.Rows.Count - 1];
            int[] quantity = new int[list2.Rows.Count - 1];
            double[] price = new double[list2.Rows.Count - 1];
            DateTime[] date = new DateTime[list2.Rows.Count - 1];
            string[] status = new string[list2.Rows.Count - 1];
            for (int i = 0; i < list2.Rows.Count - 1; i++)
            {
                idproduct[i] = int.Parse(list2.Rows[i].Cells[1].Value.ToString());
                quantity[i] = int.Parse(list2.Rows[i].Cells[3].Value.ToString());
                price[i] = double.Parse(list2.Rows[i].Cells[4].Value.ToString());
                date[i] = (DateTime)list2.Rows[i].Cells[5].Value;
                if (list2.Rows[i].Cells[6].Value!=null)
                {
                    status[i] = list2.Rows[i].Cells[6].Value.ToString();
                }
            }
            if (i == 0)
            {
                if(!a.checkNumbertype(lblTotalAmount.Text))
                {
                    MessageBox.Show("You should add Product ");
                }
                else if (bus.addHeadImport( txtIDRequest.Text, DateTime.Now, float.Parse(lblTotalAmount.Text), IDAcc, idproduct, quantity, price, date, status))
                {
                    loadList();
                    tabPage.SelectedIndex = 0;
                    txtIDProduct.Text = "";
                    txtQuantity.Text = "";
                    lblTotalAmount.Text = "....";
                    removeAllHI();
                    dateTime.Value = DateTime.Now;
                    txtIDRequest.Text = "";
                    txtPrice.Text = "";
                    txtStatus.Text = "";
                    MessageBox.Show("Success");
                }
                else MessageBox.Show("Fail");
            }
            if (i == 1)
            {
                if (a.checkNumbertype(lblTotalAmount.Text))
                {
                    MessageBox.Show("You should add Product ");
                }
                else if (bus.editHeadImport(this.id, DateTime.Now, float.Parse(lblTotalAmount.Text), IDAcc, idproduct, quantity, price, date, status))
                {
                    loadList();
                    i = 0;
                    btnEdit.Enabled = true;
                    btnCancel.Text = "Clear";
                    tabAdd.Text = "Add";
                    tabPage.SelectedIndex = 0;
                    txtIDProduct.Text = "";
                    txtQuantity.Text = "";
                    lblTotalAmount.Text = "....";
                    removeAllHI();
                    dateTime.Value = DateTime.Now;
                    txtIDRequest.Text = "";
                    txtPrice.Text = "";
                    txtStatus.Text = "";
                    MessageBox.Show("Success");
                }
                else MessageBox.Show("Fail");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (i==0)
            {
                removeAllHI();
                txtIDRequest.Text = "";
                txtIDProduct.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "";
                txtStatus.Text = "";
                dateTime.Value = DateTime.Now;
                lblTotalAmount.Text = "...";
            }
            if (i == 1)
            {
                i = 0;
                btnEdit.Enabled = true;
                removeAllHI();
                txtIDRequest.Text = "";
                txtIDProduct.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "";
                txtStatus.Text = "";
                dateTime.Value = DateTime.Now;
                lblTotalAmount.Text = "...";
                tabPage.SelectedIndex = 0;
                btnCancel.Text = "Clear";
                tabAdd.Text = "Add";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count == 1)
            {
                i = 1;
                btnEdit.Enabled = false;
                btnCancel.Text = "Cancel";
                tabAdd.Text = "Edit";
                this.id = (string)list.SelectedRows[0].Cells[0].Value;
                CMART1Entities1 db = new CMART1Entities1();
                HeadImport head = db.HeadImports.Single(s => s.IDHeadImport.Equals(id));
                dateTime.Value = head.HeadDate.Value;
                txtIDRequest.Text = head.IDrequestImport;
                lblTotalAmount.Text = head.TotalAmount.ToString();
                List<HeadImport_List> head_list = head.HeadImport_List.ToList();
                foreach (HeadImport_List bi in head_list)
                {
                    Product pro = db.Products.Single(st => st.IDProduct.Equals(bi.IDProduct));
                    list2.Rows.Add(head.IDrequestImport, bi.IDProduct, pro.Name, bi.Quantity, bi.Price, bi.Expiration, bi.Status);
                }
                tabPage.SelectedIndex = 1;
                calDetail();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            C04_Print prt = new C04_Print();
            prt.ShowDialog();
        }
    }
}
