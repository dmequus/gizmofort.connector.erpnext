using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee
{
    public class ERPEmployee : ERPNextObjectBase
    {
        public ERPEmployee() : this(new ERPObject(DocType.Employee)) { }
        public ERPEmployee(ERPObject obj) : base(obj) { }

        public static ERPEmployee Create(string employeename, string firstname, string company, Status status, string gender, string dateofbirth, string dateofjoining)

        {
            ERPEmployee obj = new ERPEmployee();
            obj.employee_name = employeename;
            obj.first_name = firstname;
            obj.company = company;
            obj.status = status;
            obj.gender = gender;
            obj.date_of_birth = dateofbirth;
            obj.date_of_joining = dateofjoining;
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

        public string first_name
        {
            get { return data.first_name; }
            set { data.first_name = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string gender
        {
            get { return data.gender; }
            set { data.gender = value; }
        }

        public string date_of_birth
        {
            get { return data.date_of_birth; }
            set { data.date_of_birth = value; }
        }

        public string date_of_joining
        {
            get { return data.date_of_joining; }
            set { data.date_of_joining = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string salutation
        {
            get { return data.salutation; }
            set { data.salutation = value; }
        }

        public string middle_name
        {
            get { return data.middle_name; }
            set { data.middle_name = value; }
        }

        public string last_name
        {
            get { return data.last_name; }
            set { data.last_name = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string employee_number
        {
            get { return data.employee_number; }
            set { data.employee_number = value; }
        }

        public string employment_type
        {
            get { return data.employment_type; }
            set { data.employment_type = value; }
        }

        public string emergency_phone_number
        {
            get { return data.emergency_phone_number; }
            set { data.emergency_phone_number = value; }
        }

        public string person_to_be_contacted
        {
            get { return data.person_to_be_contacted; }
            set { data.person_to_be_contacted = value; }
        }

        public string relation
        {
            get { return data.relation; }
            set { data.relation = value; }
        }

        public string user_id
        {
            get { return data.user_id; }
            set { data.user_id = value; }
        }

        private int _create_user_permission = 0;
        public int create_user_permission
        {
            get { return data._create_user_permission; }
            set { data._create_user_permission = value; }
        }

        public string job_applicant
        {
            get { return data.job_applicant; }
            set { data.job_applicant = value; }
        }

        public string scheduled_confirmation_date
        {
            get { return data.scheduled_confirmation_date; }
            set { data.scheduled_confirmation_date = value; }
        }

        public string final_confirmation_date
        {
            get { return data.final_confirmation_date; }
            set { data.final_confirmation_date = value; }
        }

        public string contract_end_date
        {
            get { return data.contract_end_date; }
            set { data.contract_end_date = value; }
        }

        private int _notice_number_of_days = 0;
        public int notice_number_of_days
        {
            get { return data._notice_number_of_days; }
            set { data._notice_number_of_days = value; }
        }

        public string date_of_retirement
        {
            get { return data.date_of_retirement; }
            set { data.date_of_retirement = value; }
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

        public string reports_to
        {
            get { return data.reports_to; }
            set { data.reports_to = value; }
        }

        public string grade
        {
            get { return data.grade; }
            set { data.grade = value; }
        }

        public string branch
        {
            get { return data.branch; }
            set { data.branch = value; }
        }

        public string leave_policy
        {
            get { return data.leave_policy; }
            set { data.leave_policy = value; }
        }

        public string holiday_list
        {
            get { return data.holiday_list; }
            set { data.holiday_list = value; }
        }

        public Salarymode salary_mode
        {
            get { return parseEnum<Salarymode>(data.salary_mode); }
            set { data.salary_mode = value.ToString(); }
        }

        public string bank_name
        {
            get { return data.bank_name; }
            set { data.bank_name = value; }
        }

        public string bank_ac_no
        {
            get { return data.bank_ac_no; }
            set { data.bank_ac_no = value; }
        }

        public string health_insurance_provider
        {
            get { return data.health_insurance_provider; }
            set { data.health_insurance_provider = value; }
        }

        public string health_insurance_no
        {
            get { return data.health_insurance_no; }
            set { data.health_insurance_no = value; }
        }

        public string cell_number
        {
            get { return data.cell_number; }
            set { data.cell_number = value; }
        }

        public Preferedcontactemail prefered_contact_email
        {
            get { return parseEnum<Preferedcontactemail>(data.prefered_contact_email); }
            set { data.prefered_contact_email = value.ToString(); }
        }

        public string prefered_email
        {
            get { return data.prefered_email; }
            set { data.prefered_email = value; }
        }

        public string company_email
        {
            get { return data.company_email; }
            set { data.company_email = value; }
        }

        public string personal_email
        {
            get { return data.personal_email; }
            set { data.personal_email = value; }
        }

        private int _unsubscribed = 0;
        public int unsubscribed
        {
            get { return data._unsubscribed; }
            set { data._unsubscribed = value; }
        }

        public Permanentaccommodationtype permanent_accommodation_type
        {
            get { return parseEnum<Permanentaccommodationtype>(data.permanent_accommodation_type); }
            set { data.permanent_accommodation_type = value.ToString(); }
        }

        public string permanent_address
        {
            get { return data.permanent_address; }
            set { data.permanent_address = value; }
        }

        public Currentaccommodationtype current_accommodation_type
        {
            get { return parseEnum<Currentaccommodationtype>(data.current_accommodation_type); }
            set { data.current_accommodation_type = value.ToString(); }
        }

        public string current_address
        {
            get { return data.current_address; }
            set { data.current_address = value; }
        }

        public string bio
        {
            get { return data.bio; }
            set { data.bio = value; }
        }

        public string passport_number
        {
            get { return data.passport_number; }
            set { data.passport_number = value; }
        }

        public string date_of_issue
        {
            get { return data.date_of_issue; }
            set { data.date_of_issue = value; }
        }

        public string valid_upto
        {
            get { return data.valid_upto; }
            set { data.valid_upto = value; }
        }

        public string place_of_issue
        {
            get { return data.place_of_issue; }
            set { data.place_of_issue = value; }
        }

        public Maritalstatus marital_status
        {
            get { return parseEnum<Maritalstatus>(data.marital_status); }
            set { data.marital_status = value.ToString(); }
        }

        public Bloodgroup blood_group
        {
            get { return parseEnum<Bloodgroup>(data.blood_group); }
            set { data.blood_group = value.ToString(); }
        }

        public string family_background
        {
            get { return data.family_background; }
            set { data.family_background = value; }
        }

        public string health_details
        {
            get { return data.health_details; }
            set { data.health_details = value; }
        }

        public string education
        {
            get { return data.education; }
            set { data.education = value; }
        }

        public string external_work_history
        {
            get { return data.external_work_history; }
            set { data.external_work_history = value; }
        }

        public string internal_work_history
        {
            get { return data.internal_work_history; }
            set { data.internal_work_history = value; }
        }

        public string resignation_letter_date
        {
            get { return data.resignation_letter_date; }
            set { data.resignation_letter_date = value; }
        }

        public string relieving_date
        {
            get { return data.relieving_date; }
            set { data.relieving_date = value; }
        }

        public string reason_for_leaving
        {
            get { return data.reason_for_leaving; }
            set { data.reason_for_leaving = value; }
        }

        public Leaveencashed leave_encashed
        {
            get { return parseEnum<Leaveencashed>(data.leave_encashed); }
            set { data.leave_encashed = value.ToString(); }
        }

        public string encashment_date
        {
            get { return data.encashment_date; }
            set { data.encashment_date = value; }
        }

        public string held_on
        {
            get { return data.held_on; }
            set { data.held_on = value; }
        }

        public Reasonforresignation reason_for_resignation
        {
            get { return parseEnum<Reasonforresignation>(data.reason_for_resignation); }
            set { data.reason_for_resignation = value.ToString(); }
        }

        public string new_workplace
        {
            get { return data.new_workplace; }
            set { data.new_workplace = value; }
        }

        public string feedback
        {
            get { return data.feedback; }
            set { data.feedback = value; }
        }

        private int _lft = 0;
        public int lft
        {
            get { return data._lft; }
            set { data._lft = value; }
        }

        private int _rgt = 0;
        public int rgt
        {
            get { return data._rgt; }
            set { data._rgt = value; }
        }

        public string old_parent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
        }

        public string attendance_device_id
        {
            get { return data.attendance_device_id; }
            set { data.attendance_device_id = value; }
        }

        public string default_shift
        {
            get { return data.default_shift; }
            set { data.default_shift = value; }
        }

        public string leave_approver
        {
            get { return data.leave_approver; }
            set { data.leave_approver = value; }
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
        [Description("Active")]
        Active,
        [Description("Left")]
        Left,
    }

    public enum Salarymode
    {
        [Description("Bank")]
        Bank,
        [Description("Cash")]
        Cash,
        [Description("Cheque")]
        Cheque,
    }

    public enum Preferedcontactemail
    {
        [Description("Company Email")]
        CompanyEmail,
        [Description("Personal Email")]
        PersonalEmail,
        [Description("User ID")]
        UserID,
    }

    public enum Permanentaccommodationtype
    {
        [Description("Rented")]
        Rented,
        [Description("Owned")]
        Owned,
    }

    public enum Currentaccommodationtype
    {
        [Description("Rented")]
        Rented,
        [Description("Owned")]
        Owned,
    }

    public enum Maritalstatus
    {
        [Description("Single")]
        Single,
        [Description("Married")]
        Married,
        [Description("Divorced")]
        Divorced,
        [Description("Widowed")]
        Widowed,
    }

    public enum Bloodgroup
    {
        [Description("A+")]
        APos,
        [Description("A-")]
        ANeg,
        [Description("B+")]
        BPos,
        [Description("B-")]
        BNeg,
        [Description("AB+")]
        ABPos,
        [Description("AB-")]
        ABNeg,
        [Description("O+")]
        OPos,
        [Description("O-")]
        ONeg,
    }

    public enum Leaveencashed
    {
        [Description("Yes")]
        Yes,
        [Description("No")]
        No,
    }

    public enum Reasonforresignation
    {
        [Description("Better Prospects")]
        BetterProspects,
        [Description("Health Concerns")]
        HealthConcerns,
    }


}