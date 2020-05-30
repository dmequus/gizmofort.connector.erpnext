using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_slip
{
    public class ERPSalary_slip : ERPNextObjectBase
    {
        public ERPSalary_slip() : this(new ERPObject(DocType.Salary_slip)) { }
        public ERPSalary_slip(ERPObject obj) : base(obj) { }

        public static ERPSalary_slip Create(string employeename, string postingdate, string employee, string company, double totalworkingdays, double paymentdays)

        {
            ERPSalary_slip obj = new ERPSalary_slip();
            obj.employee_name = employeename;
            obj.posting_date = postingdate;
            obj.employee = employee;
            obj.company = company;
            obj.total_working_days = totalworkingdays;
            obj.payment_days = paymentdays;
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

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public double total_working_days
        {
            get { return data.total_working_days; }
            set { data.total_working_days = value; }
        }

        public double payment_days
        {
            get { return data.payment_days; }
            set { data.payment_days = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string designation
        {
            get { return data.designation; }
            set { data.designation = value; }
        }

        public string branch
        {
            get { return data.branch; }
            set { data.branch = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string journal_entry
        {
            get { return data.journal_entry; }
            set { data.journal_entry = value; }
        }

        public string payroll_entry
        {
            get { return data.payroll_entry; }
            set { data.payroll_entry = value; }
        }

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        public long salary_slip_based_on_timesheet
        {
            get { return data.salary_slip_based_on_timesheet; }
            set { data.salary_slip_based_on_timesheet = value; }
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

        public string salary_structure
        {
            get { return data.salary_structure; }
            set { data.salary_structure = value; }
        }

        public Payrollfrequency payroll_frequency
        {
            get { return parseEnum<Payrollfrequency>(data.payroll_frequency); }
            set { data.payroll_frequency = value.ToString(); }
        }

        public double leave_without_pay
        {
            get { return data.leave_without_pay; }
            set { data.leave_without_pay = value; }
        }

        public string timesheets
        {
            get { return data.timesheets; }
            set { data.timesheets = value; }
        }

        public double total_working_hours
        {
            get { return data.total_working_hours; }
            set { data.total_working_hours = value; }
        }

        public double hour_rate
        {
            get { return data.hour_rate; }
            set { data.hour_rate = value; }
        }

        public string bank_name
        {
            get { return data.bank_name; }
            set { data.bank_name = value; }
        }

        public string bank_account_no
        {
            get { return data.bank_account_no; }
            set { data.bank_account_no = value; }
        }

        public long deduct_tax_for_unclaimed_employee_benefits
        {
            get { return data.deduct_tax_for_unclaimed_employee_benefits; }
            set { data.deduct_tax_for_unclaimed_employee_benefits = value; }
        }

        public long deduct_tax_for_unsubmitted_tax_exemption_proof
        {
            get { return data.deduct_tax_for_unsubmitted_tax_exemption_proof; }
            set { data.deduct_tax_for_unsubmitted_tax_exemption_proof = value; }
        }

        public string earnings
        {
            get { return data.earnings; }
            set { data.earnings = value; }
        }

        public string deductions
        {
            get { return data.deductions; }
            set { data.deductions = value; }
        }

        public double gross_pay
        {
            get { return data.gross_pay; }
            set { data.gross_pay = value; }
        }

        public double total_deduction
        {
            get { return data.total_deduction; }
            set { data.total_deduction = value; }
        }

        public string loans
        {
            get { return data.loans; }
            set { data.loans = value; }
        }

        public double total_principal_amount
        {
            get { return data.total_principal_amount; }
            set { data.total_principal_amount = value; }
        }

        public double total_interest_amount
        {
            get { return data.total_interest_amount; }
            set { data.total_interest_amount = value; }
        }

        public double total_loan_repayment
        {
            get { return data.total_loan_repayment; }
            set { data.total_loan_repayment = value; }
        }

        public double net_pay
        {
            get { return data.net_pay; }
            set { data.net_pay = value; }
        }

        public double rounded_total
        {
            get { return data.rounded_total; }
            set { data.rounded_total = value; }
        }

        public string total_in_words
        {
            get { return data.total_in_words; }
            set { data.total_in_words = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string payroll_cost_center
        {
            get { return data.payroll_cost_center; }
            set { data.payroll_cost_center = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Submitted")]
        Submitted,
        [Description("Cancelled")]
        Cancelled,
    }

    public enum Payrollfrequency
    {
        [Description("Monthly")]
        Monthly,
        [Description("Fortnightly")]
        Fortnightly,
        [Description("Bimonthly")]
        Bimonthly,
        [Description("Weekly")]
        Weekly,
        [Description("Daily")]
        Daily,
    }


}