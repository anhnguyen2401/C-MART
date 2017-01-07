using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Cmart
{
    public partial class XtraReport4 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport4()
        {
            InitializeComponent();
            billTableAdapter.Fill(dataSet41.Bill);
        }

    }
}
