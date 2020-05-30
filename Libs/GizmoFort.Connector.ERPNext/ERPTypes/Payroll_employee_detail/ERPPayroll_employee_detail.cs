using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payroll_employee_detail
{
    public class ERPPayroll_employee_detail : ERPNextObjectBase
    {
        public ERPPayroll_employee_detail() : this(new ERPObject(DocType.Payroll_employee_detail)) { }
        public ERPPayroll_employee_detail(ERPObject obj) : base(obj) { }

        public static ERPPayroll_employee_detail Create(string employee, string employeename, string department, string designation)

        {
            ERPPayroll_employee_detail obj = new ERPPayroll_employee_detail();
            obj.employee = employee;
            obj.employee_name = employeename;
            obj.department = department;
            obj.designation = designation;
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

        public string designation
        {
            get { return data.designation; }
            set { data.designation = value; }
        }


    }

    //Enums go here

}