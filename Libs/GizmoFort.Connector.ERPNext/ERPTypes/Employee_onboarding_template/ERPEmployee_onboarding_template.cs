using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_onboarding_template
{
    public class ERPEmployee_onboarding_template : ERPNextObjectBase
    {
        public ERPEmployee_onboarding_template() : this(new ERPObject(DocType.Employee_onboarding_template)) { }
        public ERPEmployee_onboarding_template(ERPObject obj) : base(obj) { }

        public static ERPEmployee_onboarding_template Create(string designation, string company, string department, string employeegrade, string activities)

        {
            ERPEmployee_onboarding_template obj = new ERPEmployee_onboarding_template();
            obj.designation = designation;
            obj.company = company;
            obj.department = department;
            obj.employee_grade = employeegrade;
            obj.activities = activities;
            return obj;
        }

        public string designation
        {
            get { return data.designation; }
            set
            {
                data.designation = value;
                data.name = value;
            }

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


    }

    //Enums go here

}