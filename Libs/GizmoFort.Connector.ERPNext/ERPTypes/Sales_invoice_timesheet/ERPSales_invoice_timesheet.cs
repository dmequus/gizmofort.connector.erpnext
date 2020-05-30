using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_invoice_timesheet
{
    public class ERPSales_invoice_timesheet : ERPNextObjectBase
    {
        public ERPSales_invoice_timesheet() : this(new ERPObject(DocType.Sales_invoice_timesheet)) { }
        public ERPSales_invoice_timesheet(ERPObject obj) : base(obj) { }

        public static ERPSales_invoice_timesheet Create(string timesheet, double billinghours, double billingamount, string timesheetdetail)

        {
            ERPSales_invoice_timesheet obj = new ERPSales_invoice_timesheet();
            obj.time_sheet = timesheet;
            obj.billing_hours = billinghours;
            obj.billing_amount = billingamount;
            obj.timesheet_detail = timesheetdetail;
            return obj;
        }

        public string time_sheet
        {
            get { return data.time_sheet; }
            set
            {
                data.time_sheet = value;
                data.name = value;
            }

        }

        public double billing_hours
        {
            get { return data.billing_hours; }
            set { data.billing_hours = value; }
        }

        public double billing_amount
        {
            get { return data.billing_amount; }
            set { data.billing_amount = value; }
        }

        public string timesheet_detail
        {
            get { return data.timesheet_detail; }
            set { data.timesheet_detail = value; }
        }


    }

    //Enums go here

}