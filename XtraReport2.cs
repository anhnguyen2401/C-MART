using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Cmart
{
    public partial class XtraReport2 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport2(string idhead)
        {
            InitializeComponent();
            dataTable1TableAdapter.Fill(dataSet21.DataTable1, idhead);
        }

    }
}
