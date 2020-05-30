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

        private int _statistical_component = 0;
        public int statistical_component
        {
            get { return data._statistical_component; }
            set { data._statistical_component = value; }
        }

        private int _is_tax_applicable = 0;
        public int is_tax_applicable
        {
            get { return data._is_tax_applicable; }
            set { data._is_tax_applicable = value; }
        }

        private int _is_flexible_benefit = 0;
        public int is_flexible_benefit
        {
            get { return data._is_flexible_benefit; }
            set { data._is_flexible_benefit = value; }
        }

        private int _variable_based_on_taxable_salary = 0;
        public int variable_based_on_taxable_salary
        {
            get { return data._variable_based_on_taxable_salary; }
            set { data._variable_based_on_taxable_salary = value; }
        }

        private int _depends_on_payment_days = 0;
        public int depends_on_payment_days
        {
            get { return data._depends_on_payment_days; }
            set { data._depends_on_payment_days = value; }
        }

        private int _deduct_full_tax_on_selected_payroll_date = 0;
        public int deduct_full_tax_on_selected_payroll_date
        {
            get { return data._deduct_full_tax_on_selected_payroll_date; }
            set { data._deduct_full_tax_on_selected_payroll_date = value; }
        }

        public string condition
        {
            get { return data.condition; }
            set { data.condition = value; }
        }

        private int _amount_based_on_formula = 0;
        public int amount_based_on_formula
        {
            get { return data._amount_based_on_formula; }
            set { data._amount_based_on_formula = value; }
        }

        public string formula
        {
            get { return data.formula; }
            set { data.formula = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        private int _do_not_include_in_total = 0;
        public int do_not_include_in_total
        {
            get { return data._do_not_include_in_total; }
            set { data._do_not_include_in_total = value; }
        }

        private double _default_amount = 0.0;
        public double default_amount
        {
            get { return data._default_amount; }
            set { data._default_amount = value; }
        }

        private double _additional_amount = 0.0;
        public double additional_amount
        {
            get { return data._additional_amount; }
            set { data._additional_amount = value; }
        }

        private double _tax_on_flexible_benefit = 0.0;
        public double tax_on_flexible_benefit
        {
            get { return data._tax_on_flexible_benefit; }
            set { data._tax_on_flexible_benefit = value; }
        }

        private double _tax_on_additional_salary = 0.0;
        public double tax_on_additional_salary
        {
            get { return data._tax_on_additional_salary; }
            set { data._tax_on_additional_salary = value; }
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

        private int _exempted_from_income_tax = 0;
        public int exempted_from_income_tax
        {
            get { return data._exempted_from_income_tax; }
            set { data._exempted_from_income_tax = value; }
        }


    }

    //Enums go here

}