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
    public partial class C02_Statistic : Form
    {

        public C02_Statistic(string name)
        {
            InitializeComponent();
            lblName.Text = name;
            importManagementToolStripMenuItem.Visible = false;
            billToolStripMenuItem.Visible = false;
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            C08_Product product = new C08_Product(lblName.Text);
            product.ShowDialog();
            this.Close();
        }

        private void promotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            C07_Promotion promote = new C07_Promotion(lblName.Text);
            promote.ShowDialog();
            this.Close();
        }

        private void priceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            C06_PriceHistory pricehis = new C06_PriceHistory(lblName.Text);
            pricehis.ShowDialog();
            this.Close();
        }

        private void btnFilterAll_Click(object sender, EventArgs e)
        {
            C02_StatisticBUS staBUS = new C02_StatisticBUS();
            this.dataGridView1.DataSource = staBUS.loadBillList();
            this.lblTotalQuantity.Text = TotalQuantity();
            this.lblTotalAmount.Text = TotalAmount();
            DisableAllDateTimePicker();
            DisableAllRadioButton();
        }

        private void C02_Statistic_Load(object sender, EventArgs e)
        {
            C02_StatisticBUS staBUS = new C02_StatisticBUS();
            this.dataGridView1.DataSource = staBUS.loadBillList();
            DisableAllDateTimePicker();
            this.lblTotalQuantity.Text = TotalQuantity();
            this.lblTotalAmount.Text = TotalAmount();
        }

        public void DisableAllDateTimePicker()
        {
            this.dpFromYear_FilterByYear.Enabled = false;
            this.dpToYear_FilterByYear.Enabled = false;

            this.dpFromMonth_FilterByMonth.Enabled = false;
            this.dpToMonth_FilterByMonth.Enabled = false;

            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker2.Enabled = false;
        }

        public void DisableAllRadioButton() {
            this.rbtnMonth.Checked = false; 
            this.rbtnYear.Checked = false;
            this.radioButton1.Checked = false;
        }

        private void rbtnYear_CheckedChanged(object sender, EventArgs e)
        {
            this.dpFromYear_FilterByYear.Enabled = true;
            this.dpToYear_FilterByYear.Enabled = true;

            this.dpFromMonth_FilterByMonth.Enabled = false;
            this.dpToMonth_FilterByMonth.Enabled = false;

            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker2.Enabled = false;
        }

        private void rbtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            this.dpFromYear_FilterByYear.Enabled = false;
            this.dpToYear_FilterByYear.Enabled = false;

            this.dpFromMonth_FilterByMonth.Enabled = true;
            this.dpToMonth_FilterByMonth.Enabled = true;

            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker2.Enabled = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            this.dpFromYear_FilterByYear.Enabled = false;
            this.dpToYear_FilterByYear.Enabled = false;

            this.dpFromMonth_FilterByMonth.Enabled = false;
            this.dpToMonth_FilterByMonth.Enabled = false;

            this.dateTimePicker1.Enabled = true;
            this.dateTimePicker2.Enabled = true;

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            C02_StatisticBUS staBUS = new C02_StatisticBUS();

            if (this.rbtnYear.Checked)
            {
                int yearfr = Convert.ToInt32(this.dpFromYear_FilterByYear.Value.Year.ToString());
                DateTime from = new DateTime(yearfr, 1, 1);

                int yearto = Convert.ToInt32(this.dpToYear_FilterByYear.Value.Year.ToString());
                DateTime to = new DateTime(yearto, 12, 31);

                this.dataGridView1.DataSource = staBUS.ViewYearRange(from, to);
            }

            if (rbtnMonth.Checked)
            {

                int monthfr = Convert.ToInt32(this.dpFromMonth_FilterByMonth.Value.Month.ToString());
                int yearfr = Convert.ToInt32(this.dpFromMonth_FilterByMonth.Value.Year.ToString());

                DateTime from = new DateTime(yearfr, monthfr, 1);

                int monthto = Convert.ToInt32(this.dpToMonth_FilterByMonth.Value.Month.ToString());
                int yearto = Convert.ToInt32(this.dpToMonth_FilterByMonth.Value.Year.ToString());

                DateTime to = new DateTime(yearto, monthto, 31);

                this.dataGridView1.DataSource = staBUS.ViewDateRange(from, to);
            }

            if (radioButton1.Checked)
            {

                this.dataGridView1.DataSource = staBUS.ViewDateRange(this.dateTimePicker2.Value, this.dateTimePicker1.Value);
            }
            this.lblTotalQuantity.Text = TotalQuantity();
            this.lblTotalAmount.Text = TotalAmount();
        }


        private string TotalAmount()
        {
            string result = "";
            int total = 0;
            if (this.dataGridView1.Rows.Count == 0)
            {
                result = "0";
                return result;
            }
            else
            {
                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    total = total + Convert.ToInt32(this.dataGridView1.Rows[i].Cells["TotalAmount"].Value.ToString());
                }
                return result + total;
            }
        }


        private string TotalQuantity()
        {
            string result = "";
            int total = 0;
            if (this.dataGridView1.Rows.Count == 0)
            {
                result = "0";
                return result;
            }
            else
            {
                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    total = total + Convert.ToInt32(this.dataGridView1.Rows[i].Cells["TotalQuantity"].Value.ToString());
                }
                return result + total;
            }
        }
    }
}

