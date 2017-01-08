using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cmart.BUS;
namespace Cmart.Cmart_GUI
{
    public partial class C03_Bill : Form
    {
        validation a = new validation();
        C03_BillBUS bus = new C03_BillBUS();
        float Total=0;
        int Quantity=0;
        string IDAcc;
        int num = 0;
        int[] idproduct;
        int i = 0;
        public C03_Bill(string name, string IDAcc)
        {
            this.IDAcc = IDAcc;
            InitializeComponent();
            lblName.Text = name;
            importManagementToolStripMenuItem.Visible = false;
            billToolStripMenuItem.Visible = false;
            categoToolStripMenuItem.Visible = false;
            statisticToolStripMenuItem.Visible = false;
            loadBillList();
            dateTime.Enabled = false;
            lstPro.Columns.Add("IDProduct", "IDProduct");
            lstPro.Columns.Add("ProductName", "ProductName");
            lstPro.Columns.Add("Quantity","Quantity");
            lstPro.Columns.Add("Total","Total");
            txtReceived.TextChanged += TxtReceived_TextChanged;
            btnCancel.Text ="Clear";
            this.tabList.TabIndex = 0;
            this.tabAdd.TabIndex = 1;
        }

        private void TxtReceived_TextChanged(object sender, EventArgs e)
        {
            if (txtReceived.Text != null)
            {
                try
                {
                    if (float.Parse(txtReceived.Text) >= Total)
                    {
                        lblReturned.Text = (float.Parse(txtReceived.Text) - Total).ToString();
                    }
                    else lblReturned.Text = "Received >= Total";
                }
                catch (Exception)
                {
                }
            }
        }

        public void loadBillList()
        {
            lstBill.DataSource = bus.loadBillList();
            lstBill.Columns[8].Visible = false;
            lstBill.Columns[9].Visible = false;
        }
        public void AddProductList()
        {
            bool flag = false;
            for (int i = 0; i < lstPro.Rows.Count - 1; i++)
            {
              if (txtIDProduct.Text == lstPro.Rows[i].Cells[0].Value.ToString())
              {
                    flag = true;
                    bus.countMoney(int.Parse(txtIDProduct.Text), int.Parse(txtQuantity.Text));
                    lstPro.Rows[i].Cells[2].Value = txtQuantity.Text;
                    lstPro.Rows[i].Cells[3].Value = bus.getPriceProduct();
                    calDetail();
                    break;
               }
            }
            if (flag == false)
            {
                if (bus.addProductList(int.Parse(txtIDProduct.Text)))
                {
                    bus.countMoney(int.Parse(txtIDProduct.Text), int.Parse(txtQuantity.Text));
                    lstPro.Rows.Add(int.Parse(txtIDProduct.Text), bus.getnameProduct(), txtQuantity.Text, bus.getPriceProduct());
                    calDetail();
                }
                else MessageBox.Show("IDProduct is not existed");
            }
        }
        public void calDetail()
        {

            if (lstPro.Rows.Count>0)
            {
                Total = 0;
                Quantity = 0;
                for (int i = 0; i < lstPro.Rows.Count - 1; i++)
                {
                    Total += float.Parse(lstPro.Rows[i].Cells[3].Value.ToString());
                    Quantity += int.Parse(lstPro.Rows[i].Cells[2].Value.ToString()); 
                }
                lblTotalAmount.Text = "" + Total;
                lblTotalQuantity.Text = "" + Quantity;
                if (txtReceived.Text != null)
                {
                    try
                    {
                        if (float.Parse(txtReceived.Text) >= Total)
                        {
                            lblReturned.Text = (float.Parse(txtReceived.Text) - Total).ToString();
                        }
                        else lblReturned.Text = "Received >= Total";
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = null;
            if (!a.Required(txtIDProduct))
            {
                message += "IDProduct is a required field\n";
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
            else if (!a.Range(1, 1, int.Parse(txtQuantity.Text.ToString())))
            {
                message += "Quantity is more than zero\n";
            } else 
            {
                AddProductList();
            }
            if (message != null)
            {
                MessageBox.Show(message);
            }
         
        }
        public void removeAllProduct()
        {
            lstPro.Rows.Clear();
            lstPro.Refresh();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            int[] idproduct = new int[lstPro.Rows.Count - 1];
            string[] quantity = new string[lstPro.Rows.Count - 1];
            string[] unitprice = new string[lstPro.Rows.Count - 1];
            for (int i = 0; i < lstPro.Rows.Count - 1; i++)
            {
                idproduct[i] = int.Parse(lstPro.Rows[i].Cells[0].Value.ToString());
                quantity[i] = lstPro.Rows[i].Cells[2].Value.ToString();
                float t = float.Parse(lstPro.Rows[i].Cells[3].Value.ToString()) / int.Parse(lstPro.Rows[i].Cells[2].Value.ToString());
                unitprice[i] = "" + t;
            }
            if (i==0)
            {
                string message = null;
                if (!a.Required(txtReceived))
                {
                    message += "Receive is a required field";
                }
                else
                {
                    if (!a.checkNumbertype(txtReceived.Text))
                    {
                        message += "Received is not money type";
                    }
                    else if (!a.checkNumbertype(lblReturned.Text))
                    {
                        message += "Received is not enough";
                    }
                    else if (lblTotalAmount.Text == "0")
                    {
                        message += "Add Product in bill";
                    }
                    else if (bus.addBill(lstBill.Rows[(lstBill.Rows.Count - 1)].Cells[0].Value.ToString(), DateTime.Now, lblTotalAmount.Text, txtReceived.Text, lblReturned.Text, Quantity, "1", IDAcc, idproduct, quantity, unitprice))
                    {
                        loadBillList();
                        tabList.SelectedIndex = 0;
                        txtIDProduct.Text = "";
                        txtQuantity.Text = "";
                        txtReceived.Text = "";
                        lblTotalAmount.Text = "....";
                        lblTotalQuantity.Text = "....";
                        lblReturned.Text = "....";
                        removeAllProduct();
                    } else message += "Add Bill Fail! Information is false";
                }
                if (message != null)
                {
                    MessageBox.Show(message);
                }
                else MessageBox.Show("Success");
            }
            if (i == 1)
            {
                string message = null;
                if (!a.Required(txtReceived))
                {
                    message += "Receive is a required field";
                }
                else if (lblTotalAmount.Text=="0")
                {
                    message += "Add Product in bill";
                }
                else
                {
                    if (!a.checkNumbertype(txtReceived.Text))
                    {
                        message += "Received is not money type";
                    }
                    else if (!a.checkNumbertype(lblReturned.Text))
                    {
                        message += "Received is not enough";
                    }
                    else if (bus.editBill(lstBill.SelectedRows[0].Cells[0].Value.ToString(), DateTime.Now, lblTotalAmount.Text, txtReceived.Text, lblReturned.Text, Quantity, "1", IDAcc, idproduct, quantity, unitprice))
                    {
                        loadBillList();
                        i = 0;
                        btnEdit.Enabled = true;
                        tabList.SelectedIndex = 0;
                        txtIDProduct.Text = "";
                        txtQuantity.Text = "";
                        txtReceived.Text = "";
                        lblTotalAmount.Text = "....";
                        lblTotalQuantity.Text = "....";
                        lblReturned.Text = "....";
                        removeAllProduct();
                        btnCancel.Text = "Clear";
                        tabAdd.Text = "Add";
                    }
                    else message += "Add Bill Fail! Information is false";
                }
                if (message != null)
                {
                    MessageBox.Show(message);
                }
                else MessageBox.Show("Success");
            }
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

        private void branchImportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
         
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
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

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (bus.deleteBill((string)lstBill.SelectedRows[0].Cells[0].Value))
        //    {
        //        loadBillList();
        //        MessageBox.Show("Delete Bill successfully");
        //    }
        //    else MessageBox.Show("Delete Bill fail");
        //}
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (this.lstPro.SelectedRows.Count > 0)
            {
                lstPro.Rows.RemoveAt(this.lstPro.SelectedRows[0].Index);
                calDetail();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (i==0)
            {
                txtIDProduct.Text = "";
                txtQuantity.Text = "";
                lstPro.DataSource = null;
                txtReceived.Text = "";
                lblTotalAmount.Text = "....";
                lblTotalQuantity.Text = "....";
                lblReturned.Text = "....";
                removeAllProduct();
            }
            if (i == 1)
            {
                i = 0;
                txtIDProduct.Text = "";
                txtQuantity.Text = "";
                lstPro.DataSource = null;
                txtReceived.Text = "";
                lblTotalAmount.Text = "....";
                lblTotalQuantity.Text = "....";
                lblReturned.Text = "....";
                removeAllProduct();
                btnEdit.Enabled = true;
                tabList.SelectedIndex = 0;
                btnCancel.Text = "Clear";
                tabAdd.Text = "Add";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstBill.SelectedRows.Count == 1)
            {
                //btnEdit.Enabled = false;
                i = 1;
                btnEdit.Enabled = false;
                btnCancel.Text = "Cancel";
                tabAdd.Text = "Edit";
                string id = (string)lstBill.SelectedRows[0].Cells[0].Value;
                CMART1Entities1 db = new CMART1Entities1();
                Bill bill = db.Bills.Single(s => s.IDBill.Equals(id));
                dateTime.Value = bill.BillDate;
                lblTotalQuantity.Text = bill.TotalQuantity.ToString();
                txtReceived.Text = bill.Recieved.ToString();
                lblTotalAmount.Text = bill.TotalAmount.ToString();
                lblReturned.Text = bill.Returned;
                Total = float.Parse(bill.TotalAmount);
                List<Bill_List> bill_list = bill.Bill_List.ToList();
                foreach (Bill_List bi in bill_list)
                {
                    Product pro = db.Products.Single(st => st.IDProduct.Equals(bi.IDProduct));
                    lstPro.Rows.Add(bi.IDProduct, pro.Name, bi.Quantity, float.Parse(bi.unitPrice) * int.Parse(bi.Quantity));
                }
                tabList.SelectedIndex = 1;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            C03_Print prt = new C03_Print();
            prt.ShowDialog();
        }
    }
}
