using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Training_feedback
{
    public class ERPTraining_feedback : ERPNextObjectBase
    {
        public ERPTraining_feedback() : this(new ERPObject(DocType.Training_feedback)) { }
        public ERPTraining_feedback(ERPObject obj) : base(obj) { }

        public static ERPTraining_feedback Create(string employeename, string employee, string department, string course, string trainingevent, string eventname, string trainername, string feedback, string amendedfrom)

        {
            ERPTraining_feedback obj = new ERPTraining_feedback();
            obj.employee_name = employeename;
            obj.employee = employee;
            obj.department = department;
            obj.course = course;
            obj.training_event = trainingevent;
            obj.event_name = eventname;
            obj.trainer_name = trainername;
            obj.feedback = feedback;
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

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string course
        {
            get { return data.course; }
            set { data.course = value; }
        }

        public string training_event
        {
            get { return data.training_event; }
            set { data.training_event = value; }
        }

        public string event_name
        {
            get { return data.event_name; }
            set { data.event_name = value; }
        }

        public string trainer_name
        {
            get { return data.trainer_name; }
            set { data.trainer_name = value; }
        }

        public string feedback
        {
            get { return data.feedback; }
            set { data.feedback = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}