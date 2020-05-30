using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_structure
{
    public class ERPSalary_structure : ERPNextObjectBase
    {
        public ERPSalary_structure() : this(new ERPObject(DocType.Salary_structure)) { }
        public ERPSalary_structure(ERPObject obj) : base(obj) { }

        public static ERPSalary_structure Create(string company, Isactive isactive)

        {
            ERPSalary_structure obj = new ERPSalary_structure();
            obj.company = company;
            obj.is_active = isactive;
            return obj;
        }

        public string company
        {
            get { return data.company; }
            set
            {
                data.company = value;
                data.name = value;
            }

        }

        public Isactive is_active
        {
            get { return parseEnum<Isactive>(data.is_active); }
            set { data.is_active = value.ToString(); }
        }

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        public Payrollfrequency payroll_frequency
        {
            get { return parseEnum<Payrollfrequency>(data.payroll_frequency); }
            set { data.payroll_frequency = value.ToString(); }
        }

        public Isdefault is_default
        {
            get { return parseEnum<Isdefault>(data.is_default); }
            set { data.is_default = value.ToString(); }
        }

        private int _salary_slip_based_on_timesheet = 0;
        public int salary_slip_based_on_timesheet
        {
            get { return data._salary_slip_based_on_timesheet; }
            set { data._salary_slip_based_on_timesheet = value; }
        }

        public string salary_component
        {
            get { return data.salary_component; }
            set { data.salary_component = value; }
        }

        private double _hour_rate = 0.0;
        public double hour_rate
        {
            get { return data._hour_rate; }
            set { data._hour_rate = value; }
        }

        private double _leave_encashment_amount_per_day = 0.0;
        public double leave_encashment_amount_per_day
        {
            get { return data._leave_encashment_amount_per_day; }
            set { data._leave_encashment_amount_per_day = value; }
        }

        private double _max_benefits = 0.0;
        public double max_benefits
        {
            get { return data._max_benefits; }
            set { data._max_benefits = value; }
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

        private double _total_earning = 0.0;
        public double total_earning
        {
            get { return data._total_earning; }
            set { data._total_earning = value; }
        }

        private double _total_deduction = 0.0;
        public double total_deduction
        {
            get { return data._total_deduction; }
            set { data._total_deduction = value; }
        }

        private double _net_pay = 0.0;
        public double net_pay
        {
            get { return data._net_pay; }
            set { data._net_pay = value; }
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
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


    }

    //Enums go here
    public enum Isactive
    {
        [Description("Yes")]
        Yes,
        [Description("No")]
        No,
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

    public enum Isdefault
    {
        [Description("Yes")]
        Yes,
        [Description("No")]
        No,
    }


}