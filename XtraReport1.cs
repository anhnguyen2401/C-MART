using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Cmart
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1(string idbill)
        {
            InitializeComponent();
            billTableAdapter.Fill(dataSet11.BillDataTable, idbill);

        }

    }
}
