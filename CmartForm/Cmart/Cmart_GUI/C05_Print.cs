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

namespace Cmart
{
    public partial class C05_Print : Form
    {
        public C05_Print()
        {
            InitializeComponent();
            this.Load += C05_Print_Load;
        }

        private void C05_Print_Load(object sender, EventArgs e)
        {
            CMART1Entities1 db = new CMART1Entities1();
            cmb.DataSource = db.BranchImports.ToList();
            cmb.ValueMember = "IDBranchImport";
            cmb.ValueMember = "IDBranchImport";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(cmb.SelectedValue);
            XtraReport3 rpt = new XtraReport3(id);
            ReportPrintTool tool = new ReportPrintTool(rpt);
            rpt.ShowPreviewDialog();
        }
    }
}
