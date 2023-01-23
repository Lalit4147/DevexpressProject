using DevExpress.Office.Utils;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace DevexpressProject
{
    public partial class XtraReport2 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport2()
        {
            InitializeComponent();
        }

        public void InitData(string orderid, DateTime orderdate, string customer, string address, string postalcode, string city, string phone,List<OrderDetail> data)
        {
            pOrderID.Value = orderid;
            pDate.Value = orderdate;
            pCustomerName.Value = customer;
            pAddress.Value = address;
            pPostalCode.Value = postalcode;
            pCity.Value = city;
            pPhone.Value = phone;
            objectDataSource1.DataSource = data;
        }

    }
}
