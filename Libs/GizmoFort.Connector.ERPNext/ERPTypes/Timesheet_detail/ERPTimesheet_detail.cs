using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Timesheet_detail
{
    public class ERPTimesheet_detail : ERPNextObjectBase
    {
        public ERPTimesheet_detail() : this(new ERPObject(DocType.Timesheet_detail)) { }
        public ERPTimesheet_detail(ERPObject obj) : base(obj) { }

        public static ERPTimesheet_detail Create(string activitytype, string fromtime, double expectedhours, double hours, string totime, long completed, double completedqty, string workstation, string operation, string operationid, string project, string task, long billable, double billinghours, double billingrate, double billingamount, double costingrate, double costingamount, string salesinvoice)

        {
            ERPTimesheet_detail obj = new ERPTimesheet_detail();
            obj.activity_type = activitytype;
            obj.from_time = fromtime;
            obj.expected_hours = expectedhours;
            obj.hours = hours;
            obj.to_time = totime;
            obj.completed = completed;
            obj.completed_qty = completedqty;
            obj.workstation = workstation;
            obj.operation = operation;
            obj.operation_id = operationid;
            obj.project = project;
            obj.task = task;
            obj.billable = billable;
            obj.billing_hours = billinghours;
            obj.billing_rate = billingrate;
            obj.billing_amount = billingamount;
            obj.costing_rate = costingrate;
            obj.costing_amount = costingamount;
            obj.sales_invoice = salesinvoice;
            return obj;
        }

        public string activity_type
        {
            get { return data.activity_type; }
            set
            {
                data.activity_type = value;
                data.name = value;
            }

        }

        public string from_time
        {
            get { return data.from_time; }
            set { data.from_time = value; }
        }

        public double expected_hours
        {
            get { return data.expected_hours; }
            set { data.expected_hours = value; }
        }

        public double hours
        {
            get { return data.hours; }
            set { data.hours = value; }
        }

        public string to_time
        {
            get { return data.to_time; }
            set { data.to_time = value; }
        }

        public long completed
        {
            get { return data.completed; }
            set { data.completed = value; }
        }

        public double completed_qty
        {
            get { return data.completed_qty; }
            set { data.completed_qty = value; }
        }

        public string workstation
        {
            get { return data.workstation; }
            set { data.workstation = value; }
        }

        public string operation
        {
            get { return data.operation; }
            set { data.operation = value; }
        }

        public string operation_id
        {
            get { return data.operation_id; }
            set { data.operation_id = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string task
        {
            get { return data.task; }
            set { data.task = value; }
        }

        public long billable
        {
            get { return data.billable; }
            set { data.billable = value; }
        }

        public double billing_hours
        {
            get { return data.billing_hours; }
            set { data.billing_hours = value; }
        }

        public double billing_rate
        {
            get { return data.billing_rate; }
            set { data.billing_rate = value; }
        }

        public double billing_amount
        {
            get { return data.billing_amount; }
            set { data.billing_amount = value; }
        }

        public double costing_rate
        {
            get { return data.costing_rate; }
            set { data.costing_rate = value; }
        }

        public double costing_amount
        {
            get { return data.costing_amount; }
            set { data.costing_amount = value; }
        }

        public string sales_invoice
        {
            get { return data.sales_invoice; }
            set { data.sales_invoice = value; }
        }


    }

    //Enums go here

}