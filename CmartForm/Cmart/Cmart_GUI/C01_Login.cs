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
using Cmart.Cmart_GUI;
namespace Cmart
{
    public partial class C01_Login : Form
    {
        validation a = new validation();
        C01_LoginBUS login;
        public C01_Login()
        {
            InitializeComponent();
            this.txtSupplier.KeyPress += TxtSupplier_KeyPress;
        }

        private void TxtSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string message = null;
                string UserName = txtName.Text;
                string Password = txtSupplier.Text;
                if (!a.Required(txtName))
                {
                    message += "Name is a required field\n";
                }
                if (!a.Required(txtSupplier))
                {
                    message += "Password is a required field\n";
                }
                else
                {
                    login = new BUS.C01_LoginBUS(UserName);
                    var acc = login.FindAcc();
                    if (acc != null)
                    {
                        if (!a.Compare(Password, login.getPassWord()))
                        {
                            message += "User or Password is wrong\n ";
                        }
                        else
                        {
                            this.Hide();
                            int position = a.Compareposition(login.getPosition());
                            if (position == 0)
                            {
                                Cmart_GUI.C08_Product product = new Cmart_GUI.C08_Product(login.getFullName());
                                product.ShowDialog();
                            }
                            else if (position == 1)
                            {
                                Cmart_GUI.C04_HeadImport headImport = new Cmart_GUI.C04_HeadImport(login.getFullName(), login.getIDAcc());
                                headImport.ShowDialog();
                            }
                            else if (position == 2)
                            {
                                Cmart_GUI.C03_Bill bill = new Cmart_GUI.C03_Bill(login.getFullName(), login.getIDAcc());
                                bill.ShowDialog();
                            }
                            else if (position == 3)
                            {
                                Cmart_GUI.C05_BranchImport branch = new Cmart_GUI.C05_BranchImport(login.getFullName(), login.getIDAcc());
                                branch.ShowDialog();
                            }
                            else if (position == 4)
                            {
                                MessageBox.Show("Now app is not been update any function for your position.");
                            }
                            this.Close();
                        }
                    }
                    else message += "User is not existed";
                }
                if (message != null)
                {
                    MessageBox.Show(message);
                }
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string message = null;
            string UserName = txtName.Text;
            string Password = txtSupplier.Text;
            if (!a.Required(txtName))
            {
                message += "Name is a required field\n";
            }
            if (!a.Required(txtSupplier))
            {
                message += "Password is a required field\n";
            }
            else
            {
                login = new BUS.C01_LoginBUS(UserName);
                var acc = login.FindAcc();
                if (acc!=null)
                {
                    if (!a.Compare(Password, login.getPassWord()))
                    {
                        message += "User or Password is wrong\n ";
                    }
                    else
                    {
                        this.Hide();
                        int position = a.Compareposition(login.getPosition());
                        if (position == 0)
                        {
                            Cmart_GUI.C08_Product product = new Cmart_GUI.C08_Product(login.getFullName());
                            product.ShowDialog();
                        }
                        else if (position == 1)
                        {
                            Cmart_GUI.C04_HeadImport headImport = new Cmart_GUI.C04_HeadImport(login.getFullName(), login.getIDAcc());
                            headImport.ShowDialog();
                        }
                        else if (position == 2)
                        {
                            Cmart_GUI.C03_Bill bill = new Cmart_GUI.C03_Bill(login.getFullName(),login.getIDAcc());
                            bill.ShowDialog();
                        }
                        else if (position == 3)
                        {
                            Cmart_GUI.C05_BranchImport branch = new Cmart_GUI.C05_BranchImport(login.getFullName(), login.getIDAcc());
                            branch.ShowDialog();
                        }
                        else if (position == 4)
                        {
                            MessageBox.Show("Now app is not been update any function for your position.");
                        }
                        this.Close();
                    }
                }
                else message += "User is not existed";
            }
            if (message != null)
            {
                MessageBox.Show(message);
            }
        }
    }
}
