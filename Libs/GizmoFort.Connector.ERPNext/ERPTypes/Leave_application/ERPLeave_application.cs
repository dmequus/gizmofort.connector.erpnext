using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_application
{
    public class ERPLeave_application : ERPNextObjectBase
    {
        public ERPLeave_application() : this(new ERPObject(DocType.Leave_application)) { }
        public ERPLeave_application(ERPObject obj) : base(obj) { }

        public static ERPLeave_application Create(string employeename, string namingseries, string employee, string leavetype, string fromdate, string todate, Status status, string postingdate, string company)

        {
            ERPLeave_application obj = new ERPLeave_application();
            obj.employee_name = employeename;
            obj.naming_series = namingseries;
            obj.employee = employee;
            obj.leave_type = leavetype;
            obj.from_date = fromdate;
            obj.to_date = todate;
            obj.status = status;
            obj.posting_date = postingdate;
            obj.company = company;
            return obj;
        }

        public string employee_name
        {
            get { return data.employee_name; }
            set
            {
                data.employee_name = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string leave_type
        {
            get { return data.leave_type; }
            set { data.leave_type = value; }
        }

        public string from_date
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public double leave_balance
        {
            get { return data.leave_balance; }
            set { data.leave_balance = value; }
        }

        public long half_day
        {
            get { return data.half_day; }
            set { data.half_day = value; }
        }

        public string half_day_date
        {
            get { return data.half_day_date; }
            set { data.half_day_date = value; }
        }

        public double total_leave_days
        {
            get { return data.total_leave_days; }
            set { data.total_leave_days = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string leave_approver
        {
            get { return data.leave_approver; }
            set { data.leave_approver = value; }
        }

        public string leave_approver_name
        {
            get { return data.leave_approver_name; }
            set { data.leave_approver_name = value; }
        }

        public long follow_via_email
        {
            get { return data.follow_via_email; }
            set { data.follow_via_email = value; }
        }

        public string salary_slip
        {
            get { return data.salary_slip; }
            set { data.salary_slip = value; }
        }

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        public string color
        {
            get { return data.color; }
            set { data.color = value; }
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
        [Description("Open")]
        Open,
        [Description("Approved")]
        Approved,
        [Description("Rejected")]
        Rejected,
        [Description("Cancelled")]
        Cancelled,
    }


}