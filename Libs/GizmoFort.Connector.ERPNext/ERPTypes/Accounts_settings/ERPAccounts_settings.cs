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

        public long auto_accounting_for_stock
        {
            get { return data.auto_accounting_for_stock; }
            set { data.auto_accounting_for_stock = value; }
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

        public long check_supplier_invoice_uniqueness
        {
            get { return data.check_supplier_invoice_uniqueness; }
            set { data.check_supplier_invoice_uniqueness = value; }
        }

        public long make_payment_via_journal_entry
        {
            get { return data.make_payment_via_journal_entry; }
            set { data.make_payment_via_journal_entry = value; }
        }

        public long unlink_payment_on_cancellation_of_invoice
        {
            get { return data.unlink_payment_on_cancellation_of_invoice; }
            set { data.unlink_payment_on_cancellation_of_invoice = value; }
        }

        public long unlink_advance_payment_on_cancelation_of_order
        {
            get { return data.unlink_advance_payment_on_cancelation_of_order; }
            set { data.unlink_advance_payment_on_cancelation_of_order = value; }
        }

        public long book_asset_depreciation_entry_automatically
        {
            get { return data.book_asset_depreciation_entry_automatically; }
            set { data.book_asset_depreciation_entry_automatically = value; }
        }

        public long allow_cost_center_in_entry_of_bs_account
        {
            get { return data.allow_cost_center_in_entry_of_bs_account; }
            set { data.allow_cost_center_in_entry_of_bs_account = value; }
        }

        public long add_taxes_from_item_tax_template
        {
            get { return data.add_taxes_from_item_tax_template; }
            set { data.add_taxes_from_item_tax_template = value; }
        }

        public long show_inclusive_tax_in_print
        {
            get { return data.show_inclusive_tax_in_print; }
            set { data.show_inclusive_tax_in_print = value; }
        }

        public long show_payment_schedule_in_print
        {
            get { return data.show_payment_schedule_in_print; }
            set { data.show_payment_schedule_in_print = value; }
        }

        public long allow_stale
        {
            get { return data.allow_stale; }
            set { data.allow_stale = value; }
        }

        public int stale_days
        {
            get { return data.stale_days; }
            set { data.stale_days = value; }
        }

        public long use_custom_cash_flow
        {
            get { return data.use_custom_cash_flow; }
            set { data.use_custom_cash_flow = value; }
        }

        public long automatically_fetch_payment_terms
        {
            get { return data.automatically_fetch_payment_terms; }
            set { data.automatically_fetch_payment_terms = value; }
        }

        public double over_billing_allowance
        {
            get { return data.over_billing_allowance; }
            set { data.over_billing_allowance = value; }
        }

        public long automatically_process_deferred_accounting_entry
        {
            get { return data.automatically_process_deferred_accounting_entry; }
            set { data.automatically_process_deferred_accounting_entry = value; }
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