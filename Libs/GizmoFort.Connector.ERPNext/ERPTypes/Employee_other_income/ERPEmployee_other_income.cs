using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_other_income
{
    public class ERPEmployee_other_income : ERPNextObjectBase
    {
        public ERPEmployee_other_income() : this(new ERPObject(DocType.Employee_other_income)) { }
        public ERPEmployee_other_income(ERPObject obj) : base(obj) { }

        public static ERPEmployee_other_income Create(string employee, string payrollperiod, string company, double amount)

        {
            ERPEmployee_other_income obj = new ERPEmployee_other_income();
            obj.employee = employee;
            obj.payroll_period = payrollperiod;
            obj.company = company;
            obj.amount = amount;
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

        public string payroll_period
        {
            get { return data.payroll_period; }
            set { data.payroll_period = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        public string source
        {
            get { return data.source; }
            set { data.source = value; }
        }

        public string employee_name
        {
            get { return data.employee_name; }
            set { data.employee_name = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here

}