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
    public partial class C05_BranchImport : Form
    {
        validation a = new validation();
        string IDAcc;
        int i = 0;
        C05_BranchImportBUS bus = new C05_BranchImportBUS();
        public C05_BranchImport(string name, string IDAcc)
        {
            InitializeComponent();
            this.IDAcc = IDAcc;
            label1.Text = name;
            cmbBranch.Items.Add("1");
            cmbBranch.Items.Add("2");
            cmbBranch.Items.Add("3");
            cmbBranch.Text = "1";
            importManagementToolStripMenuItem.Visible = false;
            billToolStripMenuItem.Visible = false;
            categoToolStripMenuItem.Visible = false;
            statisticToolStripMenuItem.Visible = false;
            lstBranchPro.Columns.Add("IDHead","IDHead");
            lstBranchPro.Columns.Add("IDProduct", "IDProduct");
            lstBranchPro.Columns.Add("ProductName", "ProductName");
            lstBranchPro.Columns.Add("Quantity", "Quantity");
            lstBranchPro.Columns.Add("Status", "Status");
            this.tabList.TabIndex = 0;
            this.tabAdd.TabIndex = 1;
            btnCancel.Text = "Clear";
            dateTime.Enabled = false;
            loadList();
            loadIDHI();
            txtIDProduct.TextChanged += TxtIDProduct_TextChanged;
            txtIDHead.TextChanged += TxtIDHead_TextChanged;
        }

        private void TxtIDHead_TextChanged(object sender, EventArgs e)
        {
        a: if (txtIDProduct.Items.Count > 0)
            {
                txtIDProduct.Items.RemoveAt(0);
                goto a;
            }
            loadIDPro();
        }

        private void TxtIDProduct_TextChanged(object sender, EventArgs e)
        {

        }

        public void loadList()
        {
            lstBranch.DataSource = bus.loadListBranchImport();
            lstBranch.Columns[5].Visible = false;
            lstBranch.Columns[6].Visible = false;
        }
        public void loadIDHI()
        {
            CMART1Entities1 db = new CMART1Entities1();
            List<HeadImport> re = db.HeadImports.ToList();
            foreach (HeadImport ri in re)
            {
                txtIDHead.Items.Add(ri.IDHeadImport);

            }
            txtIDHead.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void loadIDPro()
        {
            CMART1Entities1 db = new CMART1Entities1();
            List<HeadImport_List> re = db.HeadImport_List.Where(st => st.IDHeadImport.Equals(txtIDHead.Text)).ToList();
            foreach (HeadImport_List idpro in re)
            {
                txtIDProduct.Items.Add(idpro.IDProduct);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int[] idproduct = new int[lstBranchPro.Rows.Count - 1];
            int[] quantity = new int[lstBranchPro.Rows.Count - 1];
            string[] status = new string[lstBranchPro.Rows.Count - 1];
            for (int i = 0; i < lstBranchPro.Rows.Count - 1; i++)
            {
                idproduct[i] = int.Parse(lstBranchPro.Rows[i].Cells[1].Value.ToString());
                quantity[i] = int.Parse(lstBranchPro.Rows[i].Cells[3].Value.ToString());
                if (lstBranchPro.Rows[i].Cells[4].Value!=null)
                {
                    status[i] = lstBranchPro.Rows[i].Cells[4].Value.ToString();
                }
            }
            if (i==0)
            {
                if (lstBranchPro.Rows.Count==1)
                {
                    MessageBox.Show("You should add Product");
                }
                else if (bus.addBranchImport(txtIDHead.Text, DateTime.Now, int.Parse(cmbBranch.SelectedItem.ToString()), IDAcc, idproduct, quantity, status))
                {
                    loadList();
                    tabpage.SelectedIndex = 0;
                    txtIDProduct.Text = "";
                    txtQuantity.Text = "";
                    removeAllBI();
                    dateTime.Value = DateTime.Now;
                    txtIDHead.Text = "";
                    txtStatus.Text = "";
                    MessageBox.Show("Success");
                }
                else MessageBox.Show("Fail");
            }
            if (i == 1)
            {
                if (lstBranchPro.Rows.Count == 1)
                {
                    MessageBox.Show("You should add Product");
                }
                else
                if (bus.editBranchImport(lstBranch.Rows[(lstBranch.Rows.Count - 1)].Cells[0].Value.ToString(), dateTime.Value, int.Parse(cmbBranch.SelectedItem.ToString()), IDAcc, idproduct, quantity, status))
                {
                    loadList();
                    tabpage.SelectedIndex = 0;
                    txtIDProduct.Text = "";
                    txtQuantity.Text = "";
                    removeAllBI();
                    dateTime.Value = DateTime.Now;
                    txtIDHead.Text = "";
                    txtStatus.Text = "";
                    MessageBox.Show("Success");
                }
                else MessageBox.Show("Fail");
            }
        }
        public void removeAllBI()
        {
            lstBranchPro.Rows.Clear();
            lstBranchPro.Refresh();
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

        private void headImportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void branchImportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void billToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void statisticToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            C01_Login a = new C01_Login();
            a.ShowDialog();
            this.Close();
        }

        private void C05_BranchImport_Load(object sender, EventArgs e)
        {

        }

        private void tabAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstBranch.DataSource = bus.searchBranchImport(txtSearch.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bus.deleteBranchImport((string)lstBranch.SelectedRows[0].Cells[0].Value))
            {
                loadList();
                MessageBox.Show("Delete HeadImport successfully");
            }
            else MessageBox.Show("Delete HeadImport fail");
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (this.lstBranchPro.SelectedRows.Count > 0)
            {
                lstBranchPro.Rows.RemoveAt(this.lstBranchPro.SelectedRows[0].Index);
            }
        }

        public void addBranch()
        {
            if (bus.checkexistIDreandIDPro(txtIDHead.Text, txtIDProduct.Text))
            {
                bool flag = false;
                for (int i = 0; i < lstBranchPro.Rows.Count - 1; i++)
                {
                    if (txtIDProduct.Text == lstBranchPro.Rows[i].Cells[1].Value.ToString())
                    {
                        flag = true;
                        lstBranchPro.Rows[i].Cells[0].Value = txtIDHead.Text;
                        lstBranchPro.Rows[i].Cells[1].Value = txtIDProduct.Text;
                        bus.addProductList(int.Parse(txtIDProduct.Text));
                        lstBranchPro.Rows[i].Cells[2].Value = bus.getNamePro();
                        lstBranchPro.Rows[i].Cells[3].Value = txtQuantity.Text;
                        lstBranchPro.Rows[i].Cells[4].Value = txtStatus.Text;
                        break;
                    }
                }
                if (flag == false)
                {
                    if (bus.addProductList(int.Parse(txtIDProduct.Text)))
                    {
                        lstBranchPro.Rows.Add(txtIDHead.Text, txtIDProduct.Text, bus.getNamePro(), txtQuantity.Text, txtStatus.Text);
                    }
                    else MessageBox.Show("IDProduct is not existed in Request");
                }
            }
            else MessageBox.Show("IDHeadImport or IDpro is not right");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = null;
            if (txtIDHead.Text==null)
            {
                message += "You should choose IDRequest\n";
            }
            else if (txtIDProduct==null)
            {
                message += "You should fill or choose idPro\n";
            }
            else if (!a.Required(txtQuantity))
            {
                message += "Quantity is a required field\n";
            }
            else if (!a.checkNumbertype(txtQuantity.Text))
            {
                message += "Quantity is not right";
            }
            else if (!a.checkNumbertype(txtIDProduct.Text))
            {
                message += "ID is not right";
            }
            else if (!a.Required(txtStatus))
            {
                message += "Price is a required field\n";
            }
            else if (!a.Range(1, 1, int.Parse(txtQuantity.Text.ToString())))
            {
                message += "Quantity is more than zero\n";
            }
            else
            {
                addBranch();
                txtIDProduct.Text = "";
                txtQuantity.Text = "";
                dateTime.Value = DateTime.Now;
                cmbBranch.Text = "1";
                txtStatus.Text = "";
            }
            if (message != null)
            {
                MessageBox.Show(message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtIDProduct.Text = "";
                txtQuantity.Text = "";
                txtIDHead.Text = "";
                dateTime.Value = DateTime.Now;
                cmbBranch.Text = "1";
                txtStatus.Text = "";
                removeAllBI();
            }
            if (i == 1)
            {
                i = 0;
                tabAdd.Text = "Add";
                txtIDHead.Text = "";
                btnCancel.Text = "Clear";
                txtIDProduct.Text = "";
                txtQuantity.Text = "";
                dateTime.Value = DateTime.Now;
                cmbBranch.Text = "1";
                txtStatus.Text = "";
                removeAllBI();
                tabpage.SelectedIndex = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstBranch.SelectedRows.Count == 1)
            {
                i = 1;
                btnCancel.Text = "Cancel";
                tabAdd.Text = "Edit";
                string id = (string)lstBranch.SelectedRows[0].Cells[0].Value;
                CMART1Entities1 db = new CMART1Entities1();
                BranchImport branch = db.BranchImports.Single(s => s.IDBranchImport.Equals(id));
                dateTime.Value = branch.BranchDate.Value;
                txtIDHead.Text = branch.IDHeadImport;
                List<BranchImport_List> branch_list = branch.BranchImport_List.ToList();
                foreach (BranchImport_List bi in branch_list)
                {
                    Product pro = db.Products.Single(st => st.IDProduct.Equals(bi.IDProduct));
                    lstBranchPro.Rows.Add(branch.IDHeadImport, bi.IDProduct, pro.Name, bi.Quantity, bi.Status);
                }
                tabpage.SelectedIndex = 1;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            C05_Print prt = new C05_Print();
            prt.ShowDialog();
        }
   
    }
}
