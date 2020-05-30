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

        public long is_tax_applicable
        {
            get { return data.is_tax_applicable; }
            set { data.is_tax_applicable = value; }
        }

        public long depends_on_payment_days
        {
            get { return data.depends_on_payment_days; }
            set { data.depends_on_payment_days = value; }
        }

        public long do_not_include_in_total
        {
            get { return data.do_not_include_in_total; }
            set { data.do_not_include_in_total = value; }
        }

        public long deduct_full_tax_on_selected_payroll_date
        {
            get { return data.deduct_full_tax_on_selected_payroll_date; }
            set { data.deduct_full_tax_on_selected_payroll_date = value; }
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public long statistical_component
        {
            get { return data.statistical_component; }
            set { data.statistical_component = value; }
        }

        public long is_flexible_benefit
        {
            get { return data.is_flexible_benefit; }
            set { data.is_flexible_benefit = value; }
        }

        public double max_benefit_amount
        {
            get { return data.max_benefit_amount; }
            set { data.max_benefit_amount = value; }
        }

        public long pay_against_benefit_claim
        {
            get { return data.pay_against_benefit_claim; }
            set { data.pay_against_benefit_claim = value; }
        }

        public long only_tax_impact
        {
            get { return data.only_tax_impact; }
            set { data.only_tax_impact = value; }
        }

        public long create_separate_payment_entry_against_benefit_claim
        {
            get { return data.create_separate_payment_entry_against_benefit_claim; }
            set { data.create_separate_payment_entry_against_benefit_claim = value; }
        }

        public long variable_based_on_taxable_salary
        {
            get { return data.variable_based_on_taxable_salary; }
            set { data.variable_based_on_taxable_salary = value; }
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

        public string help
        {
            get { return data.help; }
            set { data.help = value; }
        }

        public long round_to_the_nearest_integer
        {
            get { return data.round_to_the_nearest_integer; }
            set { data.round_to_the_nearest_integer = value; }
        }

        public long exempted_from_income_tax
        {
            get { return data.exempted_from_income_tax; }
            set { data.exempted_from_income_tax = value; }
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