using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Timesheet
{
    public class ERPTimesheet : ERPNextObjectBase
    {
        public ERPTimesheet() : this(new ERPObject(DocType.Timesheet)) { }
        public ERPTimesheet(ERPObject obj) : base(obj) { }

        public static ERPTimesheet Create(string title, string namingseries, string company, string salesinvoice, string salaryslip, Status status, string employee, string employeename, string department, string user, string startdate, string enddate, string timelogs, double totalhours, double totalbillablehours, double totalbilledhours, double totalcostingamount, double totalbillableamount, double totalbilledamount, double perbilled, string note, string amendedfrom)

        {
            ERPTimesheet obj = new ERPTimesheet();
            obj.title = title;
            obj.naming_series = namingseries;
            obj.company = company;
            obj.sales_invoice = salesinvoice;
            obj.salary_slip = salaryslip;
            obj.status = status;
            obj.employee = employee;
            obj.employee_name = employeename;
            obj.department = department;
            obj.user = user;
            obj.start_date = startdate;
            obj.end_date = enddate;
            obj.time_logs = timelogs;
            obj.total_hours = totalhours;
            obj.total_billable_hours = totalbillablehours;
            obj.total_billed_hours = totalbilledhours;
            obj.total_costing_amount = totalcostingamount;
            obj.total_billable_amount = totalbillableamount;
            obj.total_billed_amount = totalbilledamount;
            obj.per_billed = perbilled;
            obj.note = note;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string sales_invoice
        {
            get { return data.sales_invoice; }
            set { data.sales_invoice = value; }
        }

        public string salary_slip
        {
            get { return data.salary_slip; }
            set { data.salary_slip = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string employee_name
        {
            get { return data.employee_name; }
            set { data.employee_name = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string user
        {
            get { return data.user; }
            set { data.user = value; }
        }

        public string start_date
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        public string end_date
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        public string time_logs
        {
            get { return data.time_logs; }
            set { data.time_logs = value; }
        }

        private double _total_hours = 0.0;
        public double total_hours
        {
            get { return data._total_hours; }
            set { data._total_hours = value; }
        }

        private double _total_billable_hours = 0.0;
        public double total_billable_hours
        {
            get { return data._total_billable_hours; }
            set { data._total_billable_hours = value; }
        }

        private double _total_billed_hours = 0.0;
        public double total_billed_hours
        {
            get { return data._total_billed_hours; }
            set { data._total_billed_hours = value; }
        }

        private double _total_costing_amount = 0.0;
        public double total_costing_amount
        {
            get { return data._total_costing_amount; }
            set { data._total_costing_amount = value; }
        }

        private double _total_billable_amount = 0.0;
        public double total_billable_amount
        {
            get { return data._total_billable_amount; }
            set { data._total_billable_amount = value; }
        }

        private double _total_billed_amount = 0.0;
        public double total_billed_amount
        {
            get { return data._total_billed_amount; }
            set { data._total_billed_amount = value; }
        }

        private double _per_billed = 0.0;
        public double per_billed
        {
            get { return data._per_billed; }
            set { data._per_billed = value; }
        }

        public string note
        {
            get { return data.note; }
            set { data.note = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Submitted")]
        Submitted,
        [Description("Billed")]
        Billed,
        [Description("Payslip")]
        Payslip,
        [Description("Completed")]
        Completed,
        [Description("Cancelled")]
        Cancelled,
    }


}