using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_boarding_activity
{
    public class ERPEmployee_boarding_activity : ERPNextObjectBase
    {
        public ERPEmployee_boarding_activity() : this(new ERPObject(DocType.Employee_boarding_activity)) { }
        public ERPEmployee_boarding_activity(ERPObject obj) : base(obj) { }

        public static ERPEmployee_boarding_activity Create()

        {
            ERPEmployee_boarding_activity obj = new ERPEmployee_boarding_activity();
            return obj;
        }

        public string activity_name
        {
            get { return data.activity_name; }
            set
            {
                data.activity_name = value;
                data.name = value;
            }

        }

        public string user
        {
            get { return data.user; }
            set { data.user = value; }
        }

        public string role
        {
            get { return data.role; }
            set { data.role = value; }
        }

        public string task
        {
            get { return data.task; }
            set { data.task = value; }
        }

        public double task_weight
        {
            get { return data.task_weight; }
            set { data.task_weight = value; }
        }

        public long required_for_employee_creation
        {
            get { return data.required_for_employee_creation; }
            set { data.required_for_employee_creation = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}