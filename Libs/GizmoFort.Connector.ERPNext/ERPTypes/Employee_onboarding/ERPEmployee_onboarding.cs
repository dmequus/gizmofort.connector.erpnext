using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_onboarding
{
    public class ERPEmployee_onboarding : ERPNextObjectBase
    {
        public ERPEmployee_onboarding() : this(new ERPObject(DocType.Employee_onboarding)) { }
        public ERPEmployee_onboarding(ERPObject obj) : base(obj) { }

        public static ERPEmployee_onboarding Create(string employeename, string jobapplicant, string joboffer, string employee, string dateofjoining, Boardingstatus boardingstatus, int notifyusersbyemail, string employeeonboardingtemplate, string company, string department, string designation, string employeegrade, string project, string activities, string amendedfrom)

        {
            ERPEmployee_onboarding obj = new ERPEmployee_onboarding();
            obj.employee_name = employeename;
            obj.job_applicant = jobapplicant;
            obj.job_offer = joboffer;
            obj.employee = employee;
            obj.date_of_joining = dateofjoining;
            obj.boarding_status = boardingstatus;
            obj.notify_users_by_email = notifyusersbyemail;
            obj.employee_onboarding_template = employeeonboardingtemplate;
            obj.company = company;
            obj.department = department;
            obj.designation = designation;
            obj.employee_grade = employeegrade;
            obj.project = project;
            obj.activities = activities;
            obj.amended_from = amendedfrom;
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

        public string job_applicant
        {
            get { return data.job_applicant; }
            set { data.job_applicant = value; }
        }

        public string job_offer
        {
            get { return data.job_offer; }
            set { data.job_offer = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string date_of_joining
        {
            get { return data.date_of_joining; }
            set { data.date_of_joining = value; }
        }

        public Boardingstatus boarding_status
        {
            get { return parseEnum<Boardingstatus>(data.boarding_status); }
            set { data.boarding_status = value.ToString(); }
        }

        private int _notify_users_by_email = 0;
        public int notify_users_by_email
        {
            get { return data._notify_users_by_email; }
            set { data._notify_users_by_email = value; }
        }

        public string employee_onboarding_template
        {
            get { return data.employee_onboarding_template; }
            set { data.employee_onboarding_template = value; }
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

        public string designation
        {
            get { return data.designation; }
            set { data.designation = value; }
        }

        public string employee_grade
        {
            get { return data.employee_grade; }
            set { data.employee_grade = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string activities
        {
            get { return data.activities; }
            set { data.activities = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Boardingstatus
    {
        [Description("Pending")]
        Pending,
        [Description("In Process")]
        InProcess,
        [Description("Completed")]
        Completed,
    }


}