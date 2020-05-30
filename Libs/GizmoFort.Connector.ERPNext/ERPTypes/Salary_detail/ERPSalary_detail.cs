using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_detail
{
    public class ERPSalary_detail : ERPNextObjectBase
    {
        public ERPSalary_detail() : this(new ERPObject(DocType.Salary_detail)) { }
        public ERPSalary_detail(ERPObject obj) : base(obj) { }

        public static ERPSalary_detail Create(string salarycomponent)

        {
            ERPSalary_detail obj = new ERPSalary_detail();
            obj.salary_component = salarycomponent;
            return obj;
        }

        public string salary_component
        {
            get { return data.salary_component; }
            set
            {
                data.salary_component = value;
                data.name = value;
            }

        }

        public string abbr
        {
            get { return data.abbr; }
            set { data.abbr = value; }
        }

        public long statistical_component
        {
            get { return data.statistical_component; }
            set { data.statistical_component = value; }
        }

        public long is_tax_applicable
        {
            get { return data.is_tax_applicable; }
            set { data.is_tax_applicable = value; }
        }

        public long is_flexible_benefit
        {
            get { return data.is_flexible_benefit; }
            set { data.is_flexible_benefit = value; }
        }

        public long variable_based_on_taxable_salary
        {
            get { return data.variable_based_on_taxable_salary; }
            set { data.variable_based_on_taxable_salary = value; }
        }

        public long depends_on_payment_days
        {
            get { return data.depends_on_payment_days; }
            set { data.depends_on_payment_days = value; }
        }

        public long deduct_full_tax_on_selected_payroll_date
        {
            get { return data.deduct_full_tax_on_selected_payroll_date; }
            set { data.deduct_full_tax_on_selected_payroll_date = value; }
        }

        public string condition
        {
            get { return data.condition; }
            set { data.condition = value; }
        }

        public long amount_based_on_formula
        {
            get { return data.amount_based_on_formula; }
            set { data.amount_based_on_formula = value; }
        }

        public string formula
        {
            get { return data.formula; }
            set { data.formula = value; }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        public long do_not_include_in_total
        {
            get { return data.do_not_include_in_total; }
            set { data.do_not_include_in_total = value; }
        }

        public double default_amount
        {
            get { return data.default_amount; }
            set { data.default_amount = value; }
        }

        public double additional_amount
        {
            get { return data.additional_amount; }
            set { data.additional_amount = value; }
        }

        public double tax_on_flexible_benefit
        {
            get { return data.tax_on_flexible_benefit; }
            set { data.tax_on_flexible_benefit = value; }
        }

        public double tax_on_additional_salary
        {
            get { return data.tax_on_additional_salary; }
            set { data.tax_on_additional_salary = value; }
        }

        public string condition_and_formula_help
        {
            get { return data.condition_and_formula_help; }
            set { data.condition_and_formula_help = value; }
        }

        public string additional_salary
        {
            get { return data.additional_salary; }
            set { data.additional_salary = value; }
        }

        public long exempted_from_income_tax
        {
            get { return data.exempted_from_income_tax; }
            set { data.exempted_from_income_tax = value; }
        }


    }

    //Enums go here

}