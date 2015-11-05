using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PTHOrder.Reports
{
    public partial class rptListOrder : DevExpress.XtraReports.UI.XtraReport
    {
        public rptListOrder()
        {
            InitializeComponent();
        }
        public rptListOrder(string usd)
        {
           // InitializeComponent();
            if (usd != "")
            {
                xrTableCell12.DataBindings.Add("Text", null, "Table.Price", "{0:n}");
                xrTableCell13.DataBindings.Add("Text", null, "Table.Monitize", "{0:n}");
                xrTableCell20.DataBindings.Add("Text", null, "Table.SupTotal", "{0:n}");
                xrTableCell34.DataBindings.Add("Text", null, "Table.SupTotalAll", "{0:n}");
                xrTableCell27.DataBindings.Add("Text", null, "Table.SupTotal_VAT", "{0:n}");
            }
            else
            {
                xrTableCell12.DataBindings.Add("Text", null, "Table.Price", "{0:#,#}");
                xrTableCell13.DataBindings.Add("Text", null, "Table.Monitize", "{0:#,#}");
                xrTableCell20.DataBindings.Add("Text", null, "Table.SupTotal", "{0:#,#}");
                xrTableCell34.DataBindings.Add("Text", null, "Table.SupTotalAll", "{0:#,#}");
                xrTableCell27.DataBindings.Add("Text", null, "Table.SupTotal_VAT", "{0:#,#}");
            }
        }
    }
}
