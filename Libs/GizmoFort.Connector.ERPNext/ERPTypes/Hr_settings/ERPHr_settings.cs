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

        public long stop_birthday_reminders
        {
            get { return data.stop_birthday_reminders; }
            set { data.stop_birthday_reminders = value; }
        }

        public long expense_approver_mandatory_in_expense_claim
        {
            get { return data.expense_approver_mandatory_in_expense_claim; }
            set { data.expense_approver_mandatory_in_expense_claim = value; }
        }

        public long include_holidays_in_total_working_days
        {
            get { return data.include_holidays_in_total_working_days; }
            set { data.include_holidays_in_total_working_days = value; }
        }

        public double max_working_hours_against_timesheet
        {
            get { return data.max_working_hours_against_timesheet; }
            set { data.max_working_hours_against_timesheet = value; }
        }

        public long email_salary_slip_to_employee
        {
            get { return data.email_salary_slip_to_employee; }
            set { data.email_salary_slip_to_employee = value; }
        }

        public long encrypt_salary_slips_in_emails
        {
            get { return data.encrypt_salary_slips_in_emails; }
            set { data.encrypt_salary_slips_in_emails = value; }
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

        public long leave_approver_mandatory_in_leave_application
        {
            get { return data.leave_approver_mandatory_in_leave_application; }
            set { data.leave_approver_mandatory_in_leave_application = value; }
        }

        public long show_leaves_of_all_department_members_in_calendar
        {
            get { return data.show_leaves_of_all_department_members_in_calendar; }
            set { data.show_leaves_of_all_department_members_in_calendar = value; }
        }

        public long check_vacancies
        {
            get { return data.check_vacancies; }
            set { data.check_vacancies = value; }
        }

        public long auto_leave_encashment
        {
            get { return data.auto_leave_encashment; }
            set { data.auto_leave_encashment = value; }
        }

        public long disable_rounded_total
        {
            get { return data.disable_rounded_total; }
            set { data.disable_rounded_total = value; }
        }

        public long restrict_backdated_leave_application
        {
            get { return data.restrict_backdated_leave_application; }
            set { data.restrict_backdated_leave_application = value; }
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

        public double daily_wages_fraction_for_half_day
        {
            get { return data.daily_wages_fraction_for_half_day; }
            set { data.daily_wages_fraction_for_half_day = value; }
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