using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Cmart
{
    public partial class XtraReport3 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport3(string id)
        {
            InitializeComponent();
            dataTable1TableAdapter.Fill(dataSet31.DataTable1, id);
        }

    }
}
