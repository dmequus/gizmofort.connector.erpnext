using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_advance
{
    public class ERPEmployee_advance : ERPNextObjectBase
    {
        public ERPEmployee_advance() : this(new ERPObject(DocType.Employee_advance)) { }
        public ERPEmployee_advance(ERPObject obj) : base(obj) { }

        public static ERPEmployee_advance Create(string employee, string postingdate, string purpose, double advanceamount, string company, string advanceaccount)

        {
            ERPEmployee_advance obj = new ERPEmployee_advance();
            obj.employee = employee;
            obj.posting_date = postingdate;
            obj.purpose = purpose;
            obj.advance_amount = advanceamount;
            obj.company = company;
            obj.advance_account = advanceaccount;
            return obj;
        }

        public string employee
        {
            get { return data.employee; }
            set
            {
                data.employee = value;
                data.name = value;
            }

        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string purpose
        {
            get { return data.purpose; }
            set { data.purpose = value; }
        }

        public double advance_amount
        {
            get { return data.advance_amount; }
            set { data.advance_amount = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string advance_account
        {
            get { return data.advance_account; }
            set { data.advance_account = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
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

        public double paid_amount
        {
            get { return data.paid_amount; }
            set { data.paid_amount = value; }
        }

        public double due_advance_amount
        {
            get { return data.due_advance_amount; }
            set { data.due_advance_amount = value; }
        }

        public double claimed_amount
        {
            get { return data.claimed_amount; }
            set { data.claimed_amount = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
        }

        public double return_amount
        {
            get { return data.return_amount; }
            set { data.return_amount = value; }
        }

        public long repay_unclaimed_amount_from_salary
        {
            get { return data.repay_unclaimed_amount_from_salary; }
            set { data.repay_unclaimed_amount_from_salary = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Paid")]
        Paid,
        [Description("Unpaid")]
        Unpaid,
        [Description("Claimed")]
        Claimed,
        [Description("Cancelled")]
        Cancelled,
    }


}