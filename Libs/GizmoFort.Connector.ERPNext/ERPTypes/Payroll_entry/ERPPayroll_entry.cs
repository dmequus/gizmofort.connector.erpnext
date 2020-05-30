using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payroll_entry
{
    public class ERPPayroll_entry : ERPNextObjectBase
    {
        public ERPPayroll_entry() : this(new ERPObject(DocType.Payroll_entry)) { }
        public ERPPayroll_entry(ERPObject obj) : base(obj) { }

        public static ERPPayroll_entry Create(string postingdate, Payrollfrequency payrollfrequency, string company, string startdate, string enddate, string costcenter)

        {
            ERPPayroll_entry obj = new ERPPayroll_entry();
            obj.posting_date = postingdate;
            obj.payroll_frequency = payrollfrequency;
            obj.company = company;
            obj.start_date = startdate;
            obj.end_date = enddate;
            obj.cost_center = costcenter;
            return obj;
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set
            {
                data.posting_date = value;
                data.name = value;
            }

        }

        public Payrollfrequency payroll_frequency
        {
            get { return parseEnum<Payrollfrequency>(data.payroll_frequency); }
            set { data.payroll_frequency = value.ToString(); }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
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

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string branch
        {
            get { return data.branch; }
            set { data.branch = value; }
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

        public int number_of_employees
        {
            get { return data.number_of_employees; }
            set { data.number_of_employees = value; }
        }

        public string employees
        {
            get { return data.employees; }
            set { data.employees = value; }
        }

        public long validate_attendance
        {
            get { return data.validate_attendance; }
            set { data.validate_attendance = value; }
        }

        public string attendance_detail_html
        {
            get { return data.attendance_detail_html; }
            set { data.attendance_detail_html = value; }
        }

        public long salary_slip_based_on_timesheet
        {
            get { return data.salary_slip_based_on_timesheet; }
            set { data.salary_slip_based_on_timesheet = value; }
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

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string payment_account
        {
            get { return data.payment_account; }
            set { data.payment_account = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public long salary_slips_created
        {
            get { return data.salary_slips_created; }
            set { data.salary_slips_created = value; }
        }

        public long salary_slips_submitted
        {
            get { return data.salary_slips_submitted; }
            set { data.salary_slips_submitted = value; }
        }

        public string bank_account
        {
            get { return data.bank_account; }
            set { data.bank_account = value; }
        }


    }

    //Enums go here
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