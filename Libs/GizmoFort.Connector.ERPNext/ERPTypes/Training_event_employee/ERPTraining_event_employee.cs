using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Training_event_employee
{
    public class ERPTraining_event_employee : ERPNextObjectBase
    {
        public ERPTraining_event_employee() : this(new ERPObject(DocType.Training_event_employee)) { }
        public ERPTraining_event_employee(ERPObject obj) : base(obj) { }

        public static ERPTraining_event_employee Create(string employee, string employeename, string department, Status status, Attendance attendance)

        {
            ERPTraining_event_employee obj = new ERPTraining_event_employee();
            obj.employee = employee;
            obj.employee_name = employeename;
            obj.department = department;
            obj.status = status;
            obj.attendance = attendance;
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

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public Attendance attendance
        {
            get { return parseEnum<Attendance>(data.attendance); }
            set { data.attendance = value.ToString(); }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Open")]
        Open,
        [Description("Invited")]
        Invited,
        [Description("Completed")]
        Completed,
        [Description("Feedback Submitted")]
        FeedbackSubmitted,
    }

    public enum Attendance
    {
        [Description("Mandatory")]
        Mandatory,
        [Description("Optional")]
        Optional,
    }


}