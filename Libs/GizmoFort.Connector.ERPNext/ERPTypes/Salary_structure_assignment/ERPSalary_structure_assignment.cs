using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_structure_assignment
{
    public class ERPSalary_structure_assignment : ERPNextObjectBase
    {
        public ERPSalary_structure_assignment() : this(new ERPObject(DocType.Salary_structure_assignment)) { }
        public ERPSalary_structure_assignment(ERPObject obj) : base(obj) { }

        public static ERPSalary_structure_assignment Create(string employeename, string employee, string salarystructure, string fromdate, string company)

        {
            ERPSalary_structure_assignment obj = new ERPSalary_structure_assignment();
            obj.employee_name = employeename;
            obj.employee = employee;
            obj.salary_structure = salarystructure;
            obj.from_date = fromdate;
            obj.company = company;
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

        public string salary_structure
        {
            get { return data.salary_structure; }
            set { data.salary_structure = value; }
        }

        public string from_date
        {
            get { return data.from_date; }
            set { data.from_date = value; }
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

        public string designation
        {
            get { return data.designation; }
            set { data.designation = value; }
        }

        public double keyDELbase
        {
            get { return data.keyDELbase; }
            set { data.keyDELbase = value; }
        }

        public double variable
        {
            get { return data.variable; }
            set { data.variable = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string income_tax_slab
        {
            get { return data.income_tax_slab; }
            set { data.income_tax_slab = value; }
        }


    }

    //Enums go here

}