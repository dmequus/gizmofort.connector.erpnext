using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts_settings
{
    public class ERPAccounts_settings : ERPNextObjectBase
    {
        public ERPAccounts_settings() : this(new ERPObject(DocType.Accounts_settings)) { }
        public ERPAccounts_settings(ERPObject obj) : base(obj) { }

        public static ERPAccounts_settings Create()

        {
            ERPAccounts_settings obj = new ERPAccounts_settings();
            return obj;
        }

        private int _auto_accounting_for_stock = 0;
        public int auto_accounting_for_stock
        {
            get { return data._auto_accounting_for_stock; }
            set { data._auto_accounting_for_stock = value; }
        }

        public string acc_frozen_upto
        {
            get { return data.acc_frozen_upto; }
            set { data.acc_frozen_upto = value; }
        }

        public string frozen_accounts_modifier
        {
            get { return data.frozen_accounts_modifier; }
            set { data.frozen_accounts_modifier = value; }
        }

        public Determineaddresstaxcategoryfrom determine_address_tax_category_from
        {
            get { return parseEnum<Determineaddresstaxcategoryfrom>(data.determine_address_tax_category_from); }
            set { data.determine_address_tax_category_from = value.ToString(); }
        }

        public string credit_controller
        {
            get { return data.credit_controller; }
            set { data.credit_controller = value; }
        }

        private int _check_supplier_invoice_uniqueness = 0;
        public int check_supplier_invoice_uniqueness
        {
            get { return data._check_supplier_invoice_uniqueness; }
            set { data._check_supplier_invoice_uniqueness = value; }
        }

        private int _make_payment_via_journal_entry = 0;
        public int make_payment_via_journal_entry
        {
            get { return data._make_payment_via_journal_entry; }
            set { data._make_payment_via_journal_entry = value; }
        }

        private int _unlink_payment_on_cancellation_of_invoice = 0;
        public int unlink_payment_on_cancellation_of_invoice
        {
            get { return data._unlink_payment_on_cancellation_of_invoice; }
            set { data._unlink_payment_on_cancellation_of_invoice = value; }
        }

        private int _unlink_advance_payment_on_cancelation_of_order = 0;
        public int unlink_advance_payment_on_cancelation_of_order
        {
            get { return data._unlink_advance_payment_on_cancelation_of_order; }
            set { data._unlink_advance_payment_on_cancelation_of_order = value; }
        }

        private int _book_asset_depreciation_entry_automatically = 0;
        public int book_asset_depreciation_entry_automatically
        {
            get { return data._book_asset_depreciation_entry_automatically; }
            set { data._book_asset_depreciation_entry_automatically = value; }
        }

        private int _allow_cost_center_in_entry_of_bs_account = 0;
        public int allow_cost_center_in_entry_of_bs_account
        {
            get { return data._allow_cost_center_in_entry_of_bs_account; }
            set { data._allow_cost_center_in_entry_of_bs_account = value; }
        }

        private int _add_taxes_from_item_tax_template = 0;
        public int add_taxes_from_item_tax_template
        {
            get { return data._add_taxes_from_item_tax_template; }
            set { data._add_taxes_from_item_tax_template = value; }
        }

        private int _show_inclusive_tax_in_print = 0;
        public int show_inclusive_tax_in_print
        {
            get { return data._show_inclusive_tax_in_print; }
            set { data._show_inclusive_tax_in_print = value; }
        }

        private int _show_payment_schedule_in_print = 0;
        public int show_payment_schedule_in_print
        {
            get { return data._show_payment_schedule_in_print; }
            set { data._show_payment_schedule_in_print = value; }
        }

        private int _allow_stale = 0;
        public int allow_stale
        {
            get { return data._allow_stale; }
            set { data._allow_stale = value; }
        }

        private int _stale_days = 0;
        public int stale_days
        {
            get { return data._stale_days; }
            set { data._stale_days = value; }
        }

        private int _use_custom_cash_flow = 0;
        public int use_custom_cash_flow
        {
            get { return data._use_custom_cash_flow; }
            set { data._use_custom_cash_flow = value; }
        }

        private int _automatically_fetch_payment_terms = 0;
        public int automatically_fetch_payment_terms
        {
            get { return data._automatically_fetch_payment_terms; }
            set { data._automatically_fetch_payment_terms = value; }
        }

        private double _over_billing_allowance = 0.0;
        public double over_billing_allowance
        {
            get { return data._over_billing_allowance; }
            set { data._over_billing_allowance = value; }
        }

        private int _automatically_process_deferred_accounting_entry = 0;
        public int automatically_process_deferred_accounting_entry
        {
            get { return data._automatically_process_deferred_accounting_entry; }
            set { data._automatically_process_deferred_accounting_entry = value; }
        }


    }

    //Enums go here
    public enum Determineaddresstaxcategoryfrom
    {
        [Description("Billing Address")]
        BillingAddress,
        [Description("Shipping Address")]
        ShippingAddress,
    }


}