using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Training_result
{
    public class ERPTraining_result : ERPNextObjectBase
    {
        public ERPTraining_result() : this(new ERPObject(DocType.Training_result)) { }
        public ERPTraining_result(ERPObject obj) : base(obj) { }

        public static ERPTraining_result Create(string trainingevent, string employees, string amendedfrom, string employeeemails)

        {
            ERPTraining_result obj = new ERPTraining_result();
            obj.training_event = trainingevent;
            obj.employees = employees;
            obj.amended_from = amendedfrom;
            obj.employee_emails = employeeemails;
            return obj;
        }

        public string training_event
        {
            get { return data.training_event; }
            set
            {
                data.training_event = value;
                data.name = value;
            }

        }

        public string employees
        {
            get { return data.employees; }
            set { data.employees = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string employee_emails
        {
            get { return data.employee_emails; }
            set { data.employee_emails = value; }
        }


    }

    //Enums go here

}