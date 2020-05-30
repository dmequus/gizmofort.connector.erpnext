using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Expense_claim
{
    public class ERPExpense_claim : ERPNextObjectBase
    {
        public ERPExpense_claim() : this(new ERPObject(DocType.Expense_claim)) { }
        public ERPExpense_claim(ERPObject obj) : base(obj) { }

        public static ERPExpense_claim Create(string title, string namingseries, string employee, string expenses, string postingdate, string company, string payableaccount)

        {
            ERPExpense_claim obj = new ERPExpense_claim();
            obj.title = title;
            obj.naming_series = namingseries;
            obj.employee = employee;
            obj.expenses = expenses;
            obj.posting_date = postingdate;
            obj.company = company;
            obj.payable_account = payableaccount;
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

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string expenses
        {
            get { return data.expenses; }
            set { data.expenses = value; }
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

        public string payable_account
        {
            get { return data.payable_account; }
            set { data.payable_account = value; }
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

        public string expense_approver
        {
            get { return data.expense_approver; }
            set { data.expense_approver = value; }
        }

        public Approvalstatus approval_status
        {
            get { return parseEnum<Approvalstatus>(data.approval_status); }
            set { data.approval_status = value.ToString(); }
        }

        private double _total_claimed_amount = 0.0;
        public double total_claimed_amount
        {
            get { return data._total_claimed_amount; }
            set { data._total_claimed_amount = value; }
        }

        private double _total_sanctioned_amount = 0.0;
        public double total_sanctioned_amount
        {
            get { return data._total_sanctioned_amount; }
            set { data._total_sanctioned_amount = value; }
        }

        private int _is_paid = 0;
        public int is_paid
        {
            get { return data._is_paid; }
            set { data._is_paid = value; }
        }

        public string vehicle_log
        {
            get { return data.vehicle_log; }
            set { data.vehicle_log = value; }
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

        private double _total_amount_reimbursed = 0.0;
        public double total_amount_reimbursed
        {
            get { return data._total_amount_reimbursed; }
            set { data._total_amount_reimbursed = value; }
        }

        public string remark
        {
            get { return data.remark; }
            set { data.remark = value; }
        }

        public string email_id
        {
            get { return data.email_id; }
            set { data.email_id = value; }
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
        }

        public string clearance_date
        {
            get { return data.clearance_date; }
            set { data.clearance_date = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
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

        public string advances
        {
            get { return data.advances; }
            set { data.advances = value; }
        }

        private double _total_advance_amount = 0.0;
        public double total_advance_amount
        {
            get { return data._total_advance_amount; }
            set { data._total_advance_amount = value; }
        }

        public string taxes
        {
            get { return data.taxes; }
            set { data.taxes = value; }
        }

        private double _grand_total = 0.0;
        public double grand_total
        {
            get { return data._grand_total; }
            set { data._grand_total = value; }
        }

        private double _total_taxes_and_charges = 0.0;
        public double total_taxes_and_charges
        {
            get { return data._total_taxes_and_charges; }
            set { data._total_taxes_and_charges = value; }
        }


    }

    //Enums go here
    public enum Approvalstatus
    {
        [Description("Draft")]
        Draft,
        [Description("Approved")]
        Approved,
        [Description("Rejected")]
        Rejected,
    }

    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Paid")]
        Paid,
        [Description("Unpaid")]
        Unpaid,
        [Description("Rejected")]
        Rejected,
        [Description("Submitted")]
        Submitted,
        [Description("Cancelled")]
        Cancelled,
    }


}