using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Additional_salary
{
    public class ERPAdditional_salary : ERPNextObjectBase
    {
        public ERPAdditional_salary() : this(new ERPObject(DocType.Additional_salary)) { }
        public ERPAdditional_salary(ERPObject obj) : base(obj) { }

        public static ERPAdditional_salary Create(string employee, string namingseries, string salarycomponent, double amount, string company)

        {
            ERPAdditional_salary obj = new ERPAdditional_salary();
            obj.employee = employee;
            obj.naming_series = namingseries;
            obj.salary_component = salarycomponent;
            obj.amount = amount;
            obj.company = company;
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

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string salary_component
        {
            get { return data.salary_component; }
            set { data.salary_component = value; }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public long overwrite_salary_structure_amount
        {
            get { return data.overwrite_salary_structure_amount; }
            set { data.overwrite_salary_structure_amount = value; }
        }

        public long deduct_full_tax_on_selected_payroll_date
        {
            get { return data.deduct_full_tax_on_selected_payroll_date; }
            set { data.deduct_full_tax_on_selected_payroll_date = value; }
        }

        public string payroll_date
        {
            get { return data.payroll_date; }
            set { data.payroll_date = value; }
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

        public string type
        {
            get { return data.type; }
            set { data.type = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public long is_recurring
        {
            get { return data.is_recurring; }
            set { data.is_recurring = value; }
        }

        public string from_date
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        public string to_date
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        public string ref_doctype
        {
            get { return data.ref_doctype; }
            set { data.ref_doctype = value; }
        }

        public string ref_docname
        {
            get { return data.ref_docname; }
            set { data.ref_docname = value; }
        }


    }

    //Enums go here

}