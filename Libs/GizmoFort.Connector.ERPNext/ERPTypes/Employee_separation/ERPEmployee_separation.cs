using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_separation
{
    public class ERPEmployee_separation : ERPNextObjectBase
    {
        public ERPEmployee_separation() : this(new ERPObject(DocType.Employee_separation)) { }
        public ERPEmployee_separation(ERPObject obj) : base(obj) { }

        public static ERPEmployee_separation Create(string employeename, string employee, string resignationletterdate, Boardingstatus boardingstatus, long notifyusersbyemail, string employeeseparationtemplate, string company, string project, string department, string designation, string employeegrade, string activities, string exitinterview, string amendedfrom)

        {
            ERPEmployee_separation obj = new ERPEmployee_separation();
            obj.employee_name = employeename;
            obj.employee = employee;
            obj.resignation_letter_date = resignationletterdate;
            obj.boarding_status = boardingstatus;
            obj.notify_users_by_email = notifyusersbyemail;
            obj.employee_separation_template = employeeseparationtemplate;
            obj.company = company;
            obj.project = project;
            obj.department = department;
            obj.designation = designation;
            obj.employee_grade = employeegrade;
            obj.activities = activities;
            obj.exit_interview = exitinterview;
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

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string resignation_letter_date
        {
            get { return data.resignation_letter_date; }
            set { data.resignation_letter_date = value; }
        }

        public Boardingstatus boarding_status
        {
            get { return parseEnum<Boardingstatus>(data.boarding_status); }
            set { data.boarding_status = value.ToString(); }
        }

        public long notify_users_by_email
        {
            get { return data.notify_users_by_email; }
            set { data.notify_users_by_email = value; }
        }

        public string employee_separation_template
        {
            get { return data.employee_separation_template; }
            set { data.employee_separation_template = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
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

        public string activities
        {
            get { return data.activities; }
            set { data.activities = value; }
        }

        public string exit_interview
        {
            get { return data.exit_interview; }
            set { data.exit_interview = value; }
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