using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Activity_cost
{
    public class ERPActivity_cost : ERPNextObjectBase
    {
        public ERPActivity_cost() : this(new ERPObject(DocType.Activity_cost)) { }
        public ERPActivity_cost(ERPObject obj) : base(obj) { }

        public static ERPActivity_cost Create(string title, string activitytype, string employee, string employeename, string department, double billingrate, double costingrate)

        {
            ERPActivity_cost obj = new ERPActivity_cost();
            obj.title = title;
            obj.activity_type = activitytype;
            obj.employee = employee;
            obj.employee_name = employeename;
            obj.department = department;
            obj.billing_rate = billingrate;
            obj.costing_rate = costingrate;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string activity_type
        {
            get { return data.activity_type; }
            set { data.activity_type = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
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

        private double _billing_rate = 0.0;
        public double billing_rate
        {
            get { return data._billing_rate; }
            set { data._billing_rate = value; }
        }

        private double _costing_rate = 0.0;
        public double costing_rate
        {
            get { return data._costing_rate; }
            set { data._costing_rate = value; }
        }


    }

    //Enums go here

}