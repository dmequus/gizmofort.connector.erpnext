using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Hr_settings
{
    public class ERPHr_settings : ERPNextObjectBase
    {
        public ERPHr_settings() : this(new ERPObject(DocType.Hr_settings)) { }
        public ERPHr_settings(ERPObject obj) : base(obj) { }

        public static ERPHr_settings Create()

        {
            ERPHr_settings obj = new ERPHr_settings();
            return obj;
        }

        public string retirement_age
        {
            get { return data.retirement_age; }
            set
            {
                data.retirement_age = value;
                data.name = value;
            }

        }

        public Empcreatedby emp_created_by
        {
            get { return parseEnum<Empcreatedby>(data.emp_created_by); }
            set { data.emp_created_by = value.ToString(); }
        }

        private int _stop_birthday_reminders = 0;
        public int stop_birthday_reminders
        {
            get { return data._stop_birthday_reminders; }
            set { data._stop_birthday_reminders = value; }
        }

        private int _expense_approver_mandatory_in_expense_claim = 0;
        public int expense_approver_mandatory_in_expense_claim
        {
            get { return data._expense_approver_mandatory_in_expense_claim; }
            set { data._expense_approver_mandatory_in_expense_claim = value; }
        }

        private int _include_holidays_in_total_working_days = 0;
        public int include_holidays_in_total_working_days
        {
            get { return data._include_holidays_in_total_working_days; }
            set { data._include_holidays_in_total_working_days = value; }
        }

        private double _max_working_hours_against_timesheet = 0.0;
        public double max_working_hours_against_timesheet
        {
            get { return data._max_working_hours_against_timesheet; }
            set { data._max_working_hours_against_timesheet = value; }
        }

        private int _email_salary_slip_to_employee = 0;
        public int email_salary_slip_to_employee
        {
            get { return data._email_salary_slip_to_employee; }
            set { data._email_salary_slip_to_employee = value; }
        }

        private int _encrypt_salary_slips_in_emails = 0;
        public int encrypt_salary_slips_in_emails
        {
            get { return data._encrypt_salary_slips_in_emails; }
            set { data._encrypt_salary_slips_in_emails = value; }
        }

        public string password_policy
        {
            get { return data.password_policy; }
            set { data.password_policy = value; }
        }

        public string leave_approval_notification_template
        {
            get { return data.leave_approval_notification_template; }
            set { data.leave_approval_notification_template = value; }
        }

        public string leave_status_notification_template
        {
            get { return data.leave_status_notification_template; }
            set { data.leave_status_notification_template = value; }
        }

        private int _leave_approver_mandatory_in_leave_application = 0;
        public int leave_approver_mandatory_in_leave_application
        {
            get { return data._leave_approver_mandatory_in_leave_application; }
            set { data._leave_approver_mandatory_in_leave_application = value; }
        }

        private int _show_leaves_of_all_department_members_in_calendar = 0;
        public int show_leaves_of_all_department_members_in_calendar
        {
            get { return data._show_leaves_of_all_department_members_in_calendar; }
            set { data._show_leaves_of_all_department_members_in_calendar = value; }
        }

        private int _check_vacancies = 0;
        public int check_vacancies
        {
            get { return data._check_vacancies; }
            set { data._check_vacancies = value; }
        }

        private int _auto_leave_encashment = 0;
        public int auto_leave_encashment
        {
            get { return data._auto_leave_encashment; }
            set { data._auto_leave_encashment = value; }
        }

        private int _disable_rounded_total = 0;
        public int disable_rounded_total
        {
            get { return data._disable_rounded_total; }
            set { data._disable_rounded_total = value; }
        }

        private int _restrict_backdated_leave_application = 0;
        public int restrict_backdated_leave_application
        {
            get { return data._restrict_backdated_leave_application; }
            set { data._restrict_backdated_leave_application = value; }
        }

        public string role_allowed_to_create_backdated_leave_application
        {
            get { return data.role_allowed_to_create_backdated_leave_application; }
            set { data.role_allowed_to_create_backdated_leave_application = value; }
        }

        public Payrollbasedon payroll_based_on
        {
            get { return parseEnum<Payrollbasedon>(data.payroll_based_on); }
            set { data.payroll_based_on = value.ToString(); }
        }

        private double _daily_wages_fraction_for_half_day = 0.0;
        public double daily_wages_fraction_for_half_day
        {
            get { return data._daily_wages_fraction_for_half_day; }
            set { data._daily_wages_fraction_for_half_day = value; }
        }


    }

    //Enums go here
    public enum Empcreatedby
    {
        [Description("Naming Series")]
        NamingSeries,
        [Description("Employee Number")]
        EmployeeNumber,
        [Description("Full Name")]
        FullName,
    }

    public enum Payrollbasedon
    {
        [Description("Leave")]
        Leave,
        [Description("Attendance")]
        Attendance,
    }


}