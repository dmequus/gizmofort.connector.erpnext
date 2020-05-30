using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Company
{
    public class ERPCompany : ERPNextObjectBase
    {
        public ERPCompany() : this(new ERPObject(DocType.Company)) { }
        public ERPCompany(ERPObject obj) : base(obj) { }

        public static ERPCompany Create(string companyname, string abbr, string defaultcurrency, string country)

        {
            ERPCompany obj = new ERPCompany();
            obj.company_name = companyname;
            obj.abbr = abbr;
            obj.default_currency = defaultcurrency;
            obj.country = country;
            return obj;
        }

        public string company_name
        {
            get { return data.company_name; }
            set
            {
                data.company_name = value;
                data.name = value;
            }

        }

        public string abbr
        {
            get { return data.abbr; }
            set { data.abbr = value; }
        }

        public string default_currency
        {
            get { return data.default_currency; }
            set { data.default_currency = value; }
        }

        public string country
        {
            get { return data.country; }
            set { data.country = value; }
        }

        private int _is_group = 0;
        public int is_group
        {
            get { return data._is_group; }
            set { data._is_group = value; }
        }

        public string default_finance_book
        {
            get { return data.default_finance_book; }
            set { data.default_finance_book = value; }
        }

        public string domain
        {
            get { return data.domain; }
            set { data.domain = value; }
        }

        public string parent_company
        {
            get { return data.parent_company; }
            set { data.parent_company = value; }
        }

        public string company_logo
        {
            get { return data.company_logo; }
            set { data.company_logo = value; }
        }

        public string company_description
        {
            get { return data.company_description; }
            set { data.company_description = value; }
        }

        public string sales_monthly_history
        {
            get { return data.sales_monthly_history; }
            set { data.sales_monthly_history = value; }
        }

        public string transactions_annual_history
        {
            get { return data.transactions_annual_history; }
            set { data.transactions_annual_history = value; }
        }

        private double _monthly_sales_target = 0.0;
        public double monthly_sales_target
        {
            get { return data._monthly_sales_target; }
            set { data._monthly_sales_target = value; }
        }

        private double _total_monthly_sales = 0.0;
        public double total_monthly_sales
        {
            get { return data._total_monthly_sales; }
            set { data._total_monthly_sales = value; }
        }

        public string default_letter_head
        {
            get { return data.default_letter_head; }
            set { data.default_letter_head = value; }
        }

        public string default_holiday_list
        {
            get { return data.default_holiday_list; }
            set { data.default_holiday_list = value; }
        }

        private double _standard_working_hours = 0.0;
        public double standard_working_hours
        {
            get { return data._standard_working_hours; }
            set { data._standard_working_hours = value; }
        }

        public string default_warehouse_for_sales_return
        {
            get { return data.default_warehouse_for_sales_return; }
            set { data.default_warehouse_for_sales_return = value; }
        }

        public Createchartofaccountsbasedon create_chart_of_accounts_based_on
        {
            get { return parseEnum<Createchartofaccountsbasedon>(data.create_chart_of_accounts_based_on); }
            set { data.create_chart_of_accounts_based_on = value.ToString(); }
        }

        public string chart_of_accounts
        {
            get { return data.chart_of_accounts; }
            set { data.chart_of_accounts = value; }
        }

        public string existing_company
        {
            get { return data.existing_company; }
            set { data.existing_company = value; }
        }

        public string tax_id
        {
            get { return data.tax_id; }
            set { data.tax_id = value; }
        }

        public string date_of_establishment
        {
            get { return data.date_of_establishment; }
            set { data.date_of_establishment = value; }
        }

        public string default_bank_account
        {
            get { return data.default_bank_account; }
            set { data.default_bank_account = value; }
        }

        public string default_cash_account
        {
            get { return data.default_cash_account; }
            set { data.default_cash_account = value; }
        }

        public string default_receivable_account
        {
            get { return data.default_receivable_account; }
            set { data.default_receivable_account = value; }
        }

        public string round_off_account
        {
            get { return data.round_off_account; }
            set { data.round_off_account = value; }
        }

        public string round_off_cost_center
        {
            get { return data.round_off_cost_center; }
            set { data.round_off_cost_center = value; }
        }

        public string write_off_account
        {
            get { return data.write_off_account; }
            set { data.write_off_account = value; }
        }

        public string discount_allowed_account
        {
            get { return data.discount_allowed_account; }
            set { data.discount_allowed_account = value; }
        }

        public string discount_received_account
        {
            get { return data.discount_received_account; }
            set { data.discount_received_account = value; }
        }

        public string exchange_gain_loss_account
        {
            get { return data.exchange_gain_loss_account; }
            set { data.exchange_gain_loss_account = value; }
        }

        public string unrealized_exchange_gain_loss_account
        {
            get { return data.unrealized_exchange_gain_loss_account; }
            set { data.unrealized_exchange_gain_loss_account = value; }
        }

        private int _allow_account_creation_against_child_company = 0;
        public int allow_account_creation_against_child_company
        {
            get { return data._allow_account_creation_against_child_company; }
            set { data._allow_account_creation_against_child_company = value; }
        }

        public string default_payable_account
        {
            get { return data.default_payable_account; }
            set { data.default_payable_account = value; }
        }

        public string default_employee_advance_account
        {
            get { return data.default_employee_advance_account; }
            set { data.default_employee_advance_account = value; }
        }

        public string default_expense_account
        {
            get { return data.default_expense_account; }
            set { data.default_expense_account = value; }
        }

        public string default_income_account
        {
            get { return data.default_income_account; }
            set { data.default_income_account = value; }
        }

        public string default_deferred_revenue_account
        {
            get { return data.default_deferred_revenue_account; }
            set { data.default_deferred_revenue_account = value; }
        }

        public string default_deferred_expense_account
        {
            get { return data.default_deferred_expense_account; }
            set { data.default_deferred_expense_account = value; }
        }

        public string default_payroll_payable_account
        {
            get { return data.default_payroll_payable_account; }
            set { data.default_payroll_payable_account = value; }
        }

        public string default_expense_claim_payable_account
        {
            get { return data.default_expense_claim_payable_account; }
            set { data.default_expense_claim_payable_account = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        private double _credit_limit = 0.0;
        public double credit_limit
        {
            get { return data._credit_limit; }
            set { data._credit_limit = value; }
        }

        public string payment_terms
        {
            get { return data.payment_terms; }
            set { data.payment_terms = value; }
        }

        private int _enable_perpetual_inventory = 0;
        public int enable_perpetual_inventory
        {
            get { return data._enable_perpetual_inventory; }
            set { data._enable_perpetual_inventory = value; }
        }

        public string default_inventory_account
        {
            get { return data.default_inventory_account; }
            set { data.default_inventory_account = value; }
        }

        public string stock_adjustment_account
        {
            get { return data.stock_adjustment_account; }
            set { data.stock_adjustment_account = value; }
        }

        public string stock_received_but_not_billed
        {
            get { return data.stock_received_but_not_billed; }
            set { data.stock_received_but_not_billed = value; }
        }

        public string expenses_included_in_valuation
        {
            get { return data.expenses_included_in_valuation; }
            set { data.expenses_included_in_valuation = value; }
        }

        public string accumulated_depreciation_account
        {
            get { return data.accumulated_depreciation_account; }
            set { data.accumulated_depreciation_account = value; }
        }

        public string depreciation_expense_account
        {
            get { return data.depreciation_expense_account; }
            set { data.depreciation_expense_account = value; }
        }

        public string series_for_depreciation_entry
        {
            get { return data.series_for_depreciation_entry; }
            set { data.series_for_depreciation_entry = value; }
        }

        public string expenses_included_in_asset_valuation
        {
            get { return data.expenses_included_in_asset_valuation; }
            set { data.expenses_included_in_asset_valuation = value; }
        }

        public string disposal_account
        {
            get { return data.disposal_account; }
            set { data.disposal_account = value; }
        }

        public string depreciation_cost_center
        {
            get { return data.depreciation_cost_center; }
            set { data.depreciation_cost_center = value; }
        }

        public string capital_work_in_progress_account
        {
            get { return data.capital_work_in_progress_account; }
            set { data.capital_work_in_progress_account = value; }
        }

        public string asset_received_but_not_billed
        {
            get { return data.asset_received_but_not_billed; }
            set { data.asset_received_but_not_billed = value; }
        }

        public string exception_budget_approver_role
        {
            get { return data.exception_budget_approver_role; }
            set { data.exception_budget_approver_role = value; }
        }

        public string date_of_incorporation
        {
            get { return data.date_of_incorporation; }
            set { data.date_of_incorporation = value; }
        }

        public string address_html
        {
            get { return data.address_html; }
            set { data.address_html = value; }
        }

        public string date_of_commencement
        {
            get { return data.date_of_commencement; }
            set { data.date_of_commencement = value; }
        }

        public string phone_no
        {
            get { return data.phone_no; }
            set { data.phone_no = value; }
        }

        public string fax
        {
            get { return data.fax; }
            set { data.fax = value; }
        }

        public string email
        {
            get { return data.email; }
            set { data.email = value; }
        }

        public string website
        {
            get { return data.website; }
            set { data.website = value; }
        }

        public string registration_details
        {
            get { return data.registration_details; }
            set { data.registration_details = value; }
        }

        private int _lft = 0;
        public int lft
        {
            get { return data._lft; }
            set { data._lft = value; }
        }

        private int _rgt = 0;
        public int rgt
        {
            get { return data._rgt; }
            set { data._rgt = value; }
        }

        public string old_parent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
        }

        public string default_selling_terms
        {
            get { return data.default_selling_terms; }
            set { data.default_selling_terms = value; }
        }

        public string default_buying_terms
        {
            get { return data.default_buying_terms; }
            set { data.default_buying_terms = value; }
        }


    }

    //Enums go here
    public enum Createchartofaccountsbasedon
    {
        [Description("Standard Template")]
        StandardTemplate,
        [Description("Existing Company")]
        ExistingCompany,
    }


}