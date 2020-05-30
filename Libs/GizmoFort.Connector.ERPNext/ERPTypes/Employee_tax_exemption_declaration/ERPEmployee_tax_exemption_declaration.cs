using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_declaration
{
    public class ERPEmployee_tax_exemption_declaration : ERPNextObjectBase
    {
        public ERPEmployee_tax_exemption_declaration() : this(new ERPObject(DocType.Employee_tax_exemption_declaration)) { }
        public ERPEmployee_tax_exemption_declaration(ERPObject obj) : base(obj) { }

        public static ERPEmployee_tax_exemption_declaration Create(string employee, string payrollperiod)

        {
            ERPEmployee_tax_exemption_declaration obj = new ERPEmployee_tax_exemption_declaration();
            obj.employee = employee;
            obj.payroll_period = payrollperiod;
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

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string declarations
        {
            get { return data.declarations; }
            set { data.declarations = value; }
        }

        public double total_declared_amount
        {
            get { return data.total_declared_amount; }
            set { data.total_declared_amount = value; }
        }

        public double total_exemption_amount
        {
            get { return data.total_exemption_amount; }
            set { data.total_exemption_amount = value; }
        }


    }

    //Enums go here

}