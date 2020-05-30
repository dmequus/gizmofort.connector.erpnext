using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_incentive
{
    public class ERPEmployee_incentive : ERPNextObjectBase
    {
        public ERPEmployee_incentive() : this(new ERPObject(DocType.Employee_incentive)) { }
        public ERPEmployee_incentive(ERPObject obj) : base(obj) { }

        public static ERPEmployee_incentive Create(string employeename, string employee, double incentiveamount, string payrolldate, string salarycomponent)

        {
            ERPEmployee_incentive obj = new ERPEmployee_incentive();
            obj.employee_name = employeename;
            obj.employee = employee;
            obj.incentive_amount = incentiveamount;
            obj.payroll_date = payrolldate;
            obj.salary_component = salarycomponent;
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

        public double incentive_amount
        {
            get { return data.incentive_amount; }
            set { data.incentive_amount = value; }
        }

        public string payroll_date
        {
            get { return data.payroll_date; }
            set { data.payroll_date = value; }
        }

        public string salary_component
        {
            get { return data.salary_component; }
            set { data.salary_component = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }


    }

    //Enums go here

}