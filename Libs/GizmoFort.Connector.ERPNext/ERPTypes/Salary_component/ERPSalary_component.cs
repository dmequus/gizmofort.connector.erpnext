using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_component
{
    public class ERPSalary_component : ERPNextObjectBase
    {
        public ERPSalary_component() : this(new ERPObject(DocType.Salary_component)) { }
        public ERPSalary_component(ERPObject obj) : base(obj) { }

        public static ERPSalary_component Create(string salarycomponent, string salarycomponentabbr, Type type)

        {
            ERPSalary_component obj = new ERPSalary_component();
            obj.salary_component = salarycomponent;
            obj.salary_component_abbr = salarycomponentabbr;
            obj.type = type;
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

        public string salary_component_abbr
        {
            get { return data.salary_component_abbr; }
            set { data.salary_component_abbr = value; }
        }

        public Type type
        {
            get { return parseEnum<Type>(data.type); }
            set { data.type = value.ToString(); }
        }

        private int _is_tax_applicable = 0;
        public int is_tax_applicable
        {
            get { return data._is_tax_applicable; }
            set { data._is_tax_applicable = value; }
        }

        private int _depends_on_payment_days = 0;
        public int depends_on_payment_days
        {
            get { return data._depends_on_payment_days; }
            set { data._depends_on_payment_days = value; }
        }

        private int _do_not_include_in_total = 0;
        public int do_not_include_in_total
        {
            get { return data._do_not_include_in_total; }
            set { data._do_not_include_in_total = value; }
        }

        private int _deduct_full_tax_on_selected_payroll_date = 0;
        public int deduct_full_tax_on_selected_payroll_date
        {
            get { return data._deduct_full_tax_on_selected_payroll_date; }
            set { data._deduct_full_tax_on_selected_payroll_date = value; }
        }

        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        private int _statistical_component = 0;
        public int statistical_component
        {
            get { return data._statistical_component; }
            set { data._statistical_component = value; }
        }

        private int _is_flexible_benefit = 0;
        public int is_flexible_benefit
        {
            get { return data._is_flexible_benefit; }
            set { data._is_flexible_benefit = value; }
        }

        private double _max_benefit_amount = 0.0;
        public double max_benefit_amount
        {
            get { return data._max_benefit_amount; }
            set { data._max_benefit_amount = value; }
        }

        private int _pay_against_benefit_claim = 0;
        public int pay_against_benefit_claim
        {
            get { return data._pay_against_benefit_claim; }
            set { data._pay_against_benefit_claim = value; }
        }

        private int _only_tax_impact = 0;
        public int only_tax_impact
        {
            get { return data._only_tax_impact; }
            set { data._only_tax_impact = value; }
        }

        private int _create_separate_payment_entry_against_benefit_claim = 0;
        public int create_separate_payment_entry_against_benefit_claim
        {
            get { return data._create_separate_payment_entry_against_benefit_claim; }
            set { data._create_separate_payment_entry_against_benefit_claim = value; }
        }

        private int _variable_based_on_taxable_salary = 0;
        public int variable_based_on_taxable_salary
        {
            get { return data._variable_based_on_taxable_salary; }
            set { data._variable_based_on_taxable_salary = value; }
        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
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

        public string help
        {
            get { return data.help; }
            set { data.help = value; }
        }

        private int _round_to_the_nearest_integer = 0;
        public int round_to_the_nearest_integer
        {
            get { return data._round_to_the_nearest_integer; }
            set { data._round_to_the_nearest_integer = value; }
        }

        private int _exempted_from_income_tax = 0;
        public int exempted_from_income_tax
        {
            get { return data._exempted_from_income_tax; }
            set { data._exempted_from_income_tax = value; }
        }


    }

    //Enums go here
    public enum Type
    {
        [Description("Earning")]
        Earning,
        [Description("Deduction")]
        Deduction,
    }


}