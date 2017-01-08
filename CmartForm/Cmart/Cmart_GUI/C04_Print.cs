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
    public partial class C04_Print : Form
    {
        public C04_Print()
        {
            InitializeComponent();
            this.Load += C04_Print_Load;
        }

        private void C04_Print_Load(object sender, EventArgs e)
        {
            CMART1Entities1 db = new CMART1Entities1();
            cmb.DataSource = db.HeadImports.ToList();
            cmb.ValueMember = "IDHeadImport";
            cmb.ValueMember = "IDHeadImport";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(cmb.SelectedValue);
            XtraReport2 rpt = new XtraReport2(id);
            ReportPrintTool tool = new ReportPrintTool(rpt);
            rpt.ShowPreviewDialog();
        }
    }
}
