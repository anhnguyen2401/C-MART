using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace Cmart.Cmart_GUI
{
    public partial class C03_Print : Form
    {
        public C03_Print()
        {
            InitializeComponent();
            this.Load += C03_Print_Load;
        }

        private void C03_Print_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            CMART1Entities1 db = new CMART1Entities1();
            cmb.DataSource = db.Bills.ToList();
            cmb.ValueMember = "IDBill";
            cmb.ValueMember = "IDBill";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string idbill = Convert.ToString(cmb.SelectedValue);
            XtraReport1 rpt = new XtraReport1(idbill);
            ReportPrintTool tool = new ReportPrintTool(rpt);
            rpt.ShowPreviewDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
