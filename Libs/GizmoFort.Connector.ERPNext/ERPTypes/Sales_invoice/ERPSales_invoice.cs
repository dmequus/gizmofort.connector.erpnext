using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_invoice
{
    public class ERPSales_invoice : ERPNextObjectBase
    {
        public ERPSales_invoice() : this(new ERPObject(DocType.Sales_invoice)) { }
        public ERPSales_invoice(ERPObject obj) : base(obj) { }

        public static ERPSales_invoice Create(string title, string namingseries, string company, string postingdate, string currency, double conversionrate, string sellingpricelist, string pricelistcurrency, double plcconversionrate, string items, double basenettotal, double basegrandtotal, double grandtotal, string debitto)

        {
            ERPSales_invoice obj = new ERPSales_invoice();
            obj.title = title;
            obj.naming_series = namingseries;
            obj.company = company;
            obj.posting_date = postingdate;
            obj.currency = currency;
            obj.conversion_rate = conversionrate;
            obj.selling_price_list = sellingpricelist;
            obj.price_list_currency = pricelistcurrency;
            obj.plc_conversion_rate = plcconversionrate;
            obj.items = items;
            obj.base_net_total = basenettotal;
            obj.base_grand_total = basegrandtotal;
            obj.grand_total = grandtotal;
            obj.debit_to = debitto;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        private double _conversion_rate = 0.0;
        public double conversion_rate
        {
            get { return data._conversion_rate; }
            set { data._conversion_rate = value; }
        }

        public string selling_price_list
        {
            get { return data.selling_price_list; }
            set { data.selling_price_list = value; }
        }

        public string price_list_currency
        {
            get { return data.price_list_currency; }
            set { data.price_list_currency = value; }
        }

        private double _plc_conversion_rate = 0.0;
        public double plc_conversion_rate
        {
            get { return data._plc_conversion_rate; }
            set { data._plc_conversion_rate = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        private double _base_net_total = 0.0;
        public double base_net_total
        {
            get { return data._base_net_total; }
            set { data._base_net_total = value; }
        }

        private double _base_grand_total = 0.0;
        public double base_grand_total
        {
            get { return data._base_grand_total; }
            set { data._base_grand_total = value; }
        }

        private double _grand_total = 0.0;
        public double grand_total
        {
            get { return data._grand_total; }
            set { data._grand_total = value; }
        }

        public string debit_to
        {
            get { return data.debit_to; }
            set { data.debit_to = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string customer_name
        {
            get { return data.customer_name; }
            set { data.customer_name = value; }
        }

        public string tax_id
        {
            get { return data.tax_id; }
            set { data.tax_id = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        private int _is_pos = 0;
        public int is_pos
        {
            get { return data._is_pos; }
            set { data._is_pos = value; }
        }

        public string pos_profile
        {
            get { return data.pos_profile; }
            set { data.pos_profile = value; }
        }

        public string offline_pos_name
        {
            get { return data.offline_pos_name; }
            set { data.offline_pos_name = value; }
        }

        private int _is_return = 0;
        public int is_return
        {
            get { return data._is_return; }
            set { data._is_return = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string posting_time
        {
            get { return data.posting_time; }
            set { data.posting_time = value; }
        }

        private int _seta_posting_time = 0;
        public int seta_posting_time
        {
            get { return data._seta_posting_time; }
            set { data._seta_posting_time = value; }
        }

        public string due_date
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string return_against
        {
            get { return data.return_against; }
            set { data.return_against = value; }
        }

        private int _update_billed_amount_in_sales_order = 0;
        public int update_billed_amount_in_sales_order
        {
            get { return data._update_billed_amount_in_sales_order; }
            set { data._update_billed_amount_in_sales_order = value; }
        }

        public string po_no
        {
            get { return data.po_no; }
            set { data.po_no = value; }
        }

        public string po_date
        {
            get { return data.po_date; }
            set { data.po_date = value; }
        }

        public string customer_address
        {
            get { return data.customer_address; }
            set { data.customer_address = value; }
        }

        public string address_display
        {
            get { return data.address_display; }
            set { data.address_display = value; }
        }

        public string contact_person
        {
            get { return data.contact_person; }
            set { data.contact_person = value; }
        }

        public string contact_display
        {
            get { return data.contact_display; }
            set { data.contact_display = value; }
        }

        public string contact_mobile
        {
            get { return data.contact_mobile; }
            set { data.contact_mobile = value; }
        }

        public string contact_email
        {
            get { return data.contact_email; }
            set { data.contact_email = value; }
        }

        public string territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        public string shipping_address_name
        {
            get { return data.shipping_address_name; }
            set { data.shipping_address_name = value; }
        }

        public string shipping_address
        {
            get { return data.shipping_address; }
            set { data.shipping_address = value; }
        }

        public string company_address
        {
            get { return data.company_address; }
            set { data.company_address = value; }
        }

        public string company_address_display
        {
            get { return data.company_address_display; }
            set { data.company_address_display = value; }
        }

        private int _ignore_pricing_rule = 0;
        public int ignore_pricing_rule
        {
            get { return data._ignore_pricing_rule; }
            set { data._ignore_pricing_rule = value; }
        }

        public string set_warehouse
        {
            get { return data.set_warehouse; }
            set { data.set_warehouse = value; }
        }

        private int _update_stock = 0;
        public int update_stock
        {
            get { return data._update_stock; }
            set { data._update_stock = value; }
        }

        public string scan_barcode
        {
            get { return data.scan_barcode; }
            set { data.scan_barcode = value; }
        }

        public string pricing_rules
        {
            get { return data.pricing_rules; }
            set { data.pricing_rules = value; }
        }

        public string packed_items
        {
            get { return data.packed_items; }
            set { data.packed_items = value; }
        }

        public string product_bundle_help
        {
            get { return data.product_bundle_help; }
            set { data.product_bundle_help = value; }
        }

        public string timesheets
        {
            get { return data.timesheets; }
            set { data.timesheets = value; }
        }

        private double _total_billing_amount = 0.0;
        public double total_billing_amount
        {
            get { return data._total_billing_amount; }
            set { data._total_billing_amount = value; }
        }

        private double _total_qty = 0.0;
        public double total_qty
        {
            get { return data._total_qty; }
            set { data._total_qty = value; }
        }

        private double _base_total = 0.0;
        public double base_total
        {
            get { return data._base_total; }
            set { data._base_total = value; }
        }

        private double _total = 0.0;
        public double total
        {
            get { return data._total; }
            set { data._total = value; }
        }

        private double _net_total = 0.0;
        public double net_total
        {
            get { return data._net_total; }
            set { data._net_total = value; }
        }

        private double _total_net_weight = 0.0;
        public double total_net_weight
        {
            get { return data._total_net_weight; }
            set { data._total_net_weight = value; }
        }

        public string taxes_and_charges
        {
            get { return data.taxes_and_charges; }
            set { data.taxes_and_charges = value; }
        }

        public string shipping_rule
        {
            get { return data.shipping_rule; }
            set { data.shipping_rule = value; }
        }

        public string tax_category
        {
            get { return data.tax_category; }
            set { data.tax_category = value; }
        }

        public string taxes
        {
            get { return data.taxes; }
            set { data.taxes = value; }
        }

        public string other_charges_calculation
        {
            get { return data.other_charges_calculation; }
            set { data.other_charges_calculation = value; }
        }

        private double _base_total_taxes_and_charges = 0.0;
        public double base_total_taxes_and_charges
        {
            get { return data._base_total_taxes_and_charges; }
            set { data._base_total_taxes_and_charges = value; }
        }

        private double _total_taxes_and_charges = 0.0;
        public double total_taxes_and_charges
        {
            get { return data._total_taxes_and_charges; }
            set { data._total_taxes_and_charges = value; }
        }

        private int _loyalty_points = 0;
        public int loyalty_points
        {
            get { return data._loyalty_points; }
            set { data._loyalty_points = value; }
        }

        private double _loyalty_amount = 0.0;
        public double loyalty_amount
        {
            get { return data._loyalty_amount; }
            set { data._loyalty_amount = value; }
        }

        private int _redeem_loyalty_points = 0;
        public int redeem_loyalty_points
        {
            get { return data._redeem_loyalty_points; }
            set { data._redeem_loyalty_points = value; }
        }

        public string loyalty_program
        {
            get { return data.loyalty_program; }
            set { data.loyalty_program = value; }
        }

        public string loyalty_redemption_account
        {
            get { return data.loyalty_redemption_account; }
            set { data.loyalty_redemption_account = value; }
        }

        public string loyalty_redemption_cost_center
        {
            get { return data.loyalty_redemption_cost_center; }
            set { data.loyalty_redemption_cost_center = value; }
        }

        public Applydiscounton apply_discount_on
        {
            get { return parseEnum<Applydiscounton>(data.apply_discount_on); }
            set { data.apply_discount_on = value.ToString(); }
        }

        private double _base_discount_amount = 0.0;
        public double base_discount_amount
        {
            get { return data._base_discount_amount; }
            set { data._base_discount_amount = value; }
        }

        private double _additional_discount_percentage = 0.0;
        public double additional_discount_percentage
        {
            get { return data._additional_discount_percentage; }
            set { data._additional_discount_percentage = value; }
        }

        private double _discount_amount = 0.0;
        public double discount_amount
        {
            get { return data._discount_amount; }
            set { data._discount_amount = value; }
        }

        private double _base_rounding_adjustment = 0.0;
        public double base_rounding_adjustment
        {
            get { return data._base_rounding_adjustment; }
            set { data._base_rounding_adjustment = value; }
        }

        private double _base_rounded_total = 0.0;
        public double base_rounded_total
        {
            get { return data._base_rounded_total; }
            set { data._base_rounded_total = value; }
        }

        public string base_in_words
        {
            get { return data.base_in_words; }
            set { data.base_in_words = value; }
        }

        private double _rounding_adjustment = 0.0;
        public double rounding_adjustment
        {
            get { return data._rounding_adjustment; }
            set { data._rounding_adjustment = value; }
        }

        private double _rounded_total = 0.0;
        public double rounded_total
        {
            get { return data._rounded_total; }
            set { data._rounded_total = value; }
        }

        public string in_words
        {
            get { return data.in_words; }
            set { data.in_words = value; }
        }

        private double _total_advance = 0.0;
        public double total_advance
        {
            get { return data._total_advance; }
            set { data._total_advance = value; }
        }

        private double _outstanding_amount = 0.0;
        public double outstanding_amount
        {
            get { return data._outstanding_amount; }
            set { data._outstanding_amount = value; }
        }

        private int _allocate_advances_automatically = 0;
        public int allocate_advances_automatically
        {
            get { return data._allocate_advances_automatically; }
            set { data._allocate_advances_automatically = value; }
        }

        public string advances
        {
            get { return data.advances; }
            set { data.advances = value; }
        }

        public string payment_terms_template
        {
            get { return data.payment_terms_template; }
            set { data.payment_terms_template = value; }
        }

        public string payment_schedule
        {
            get { return data.payment_schedule; }
            set { data.payment_schedule = value; }
        }

        public string cash_bank_account
        {
            get { return data.cash_bank_account; }
            set { data.cash_bank_account = value; }
        }

        public string payments
        {
            get { return data.payments; }
            set { data.payments = value; }
        }

        private double _base_paid_amount = 0.0;
        public double base_paid_amount
        {
            get { return data._base_paid_amount; }
            set { data._base_paid_amount = value; }
        }

        private double _paid_amount = 0.0;
        public double paid_amount
        {
            get { return data._paid_amount; }
            set { data._paid_amount = value; }
        }

        private double _base_change_amount = 0.0;
        public double base_change_amount
        {
            get { return data._base_change_amount; }
            set { data._base_change_amount = value; }
        }

        private double _change_amount = 0.0;
        public double change_amount
        {
            get { return data._change_amount; }
            set { data._change_amount = value; }
        }

        public string account_for_change_amount
        {
            get { return data.account_for_change_amount; }
            set { data.account_for_change_amount = value; }
        }

        private double _write_off_amount = 0.0;
        public double write_off_amount
        {
            get { return data._write_off_amount; }
            set { data._write_off_amount = value; }
        }

        private double _base_write_off_amount = 0.0;
        public double base_write_off_amount
        {
            get { return data._base_write_off_amount; }
            set { data._base_write_off_amount = value; }
        }

        private int _write_off_outstanding_amount_automatically = 0;
        public int write_off_outstanding_amount_automatically
        {
            get { return data._write_off_outstanding_amount_automatically; }
            set { data._write_off_outstanding_amount_automatically = value; }
        }

        public string write_off_account
        {
            get { return data.write_off_account; }
            set { data.write_off_account = value; }
        }

        public string write_off_cost_center
        {
            get { return data.write_off_cost_center; }
            set { data.write_off_cost_center = value; }
        }

        public string tc_name
        {
            get { return data.tc_name; }
            set { data.tc_name = value; }
        }

        public string terms
        {
            get { return data.terms; }
            set { data.terms = value; }
        }

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        private int _group_same_items = 0;
        public int group_same_items
        {
            get { return data._group_same_items; }
            set { data._group_same_items = value; }
        }

        public string language
        {
            get { return data.language; }
            set { data.language = value; }
        }

        public string select_print_heading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = value; }
        }

        public string inter_company_invoice_reference
        {
            get { return data.inter_company_invoice_reference; }
            set { data.inter_company_invoice_reference = value; }
        }

        public string customer_group
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        public string campaign
        {
            get { return data.campaign; }
            set { data.campaign = value; }
        }

        private int _is_discounted = 0;
        public int is_discounted
        {
            get { return data._is_discounted; }
            set { data._is_discounted = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string source
        {
            get { return data.source; }
            set { data.source = value; }
        }

        public string party_account_currency
        {
            get { return data.party_account_currency; }
            set { data.party_account_currency = value; }
        }

        public Isopening is_opening
        {
            get { return parseEnum<Isopening>(data.is_opening); }
            set { data.is_opening = value.ToString(); }
        }

        public Cformapplicable c_form_applicable
        {
            get { return parseEnum<Cformapplicable>(data.c_form_applicable); }
            set { data.c_form_applicable = value.ToString(); }
        }

        public string c_form_no
        {
            get { return data.c_form_no; }
            set { data.c_form_no = value; }
        }

        public string remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        public string sales_partner
        {
            get { return data.sales_partner; }
            set { data.sales_partner = value; }
        }

        private double _commission_rate = 0.0;
        public double commission_rate
        {
            get { return data._commission_rate; }
            set { data._commission_rate = value; }
        }

        private double _total_commission = 0.0;
        public double total_commission
        {
            get { return data._total_commission; }
            set { data._total_commission = value; }
        }

        public string sales_team
        {
            get { return data.sales_team; }
            set { data.sales_team = value; }
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

        public string auto_repeat
        {
            get { return data.auto_repeat; }
            set { data.auto_repeat = value; }
        }

        public string against_income_account
        {
            get { return data.against_income_account; }
            set { data.against_income_account = value; }
        }

        private double _pos_total_qty = 0.0;
        public double pos_total_qty
        {
            get { return data._pos_total_qty; }
            set { data._pos_total_qty = value; }
        }

        private int _is_internal_customer = 0;
        public int is_internal_customer
        {
            get { return data._is_internal_customer; }
            set { data._is_internal_customer = value; }
        }


    }

    //Enums go here
    public enum Applydiscounton
    {
        [Description("Grand Total")]
        GrandTotal,
        [Description("Net Total")]
        NetTotal,
    }

    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Return")]
        Return,
        [Description("Credit Note Issued")]
        CreditNoteIssued,
        [Description("Submitted")]
        Submitted,
        [Description("Paid")]
        Paid,
        [Description("Unpaid")]
        Unpaid,
        [Description("Unpaid and Discounted")]
        UnpaidandDiscounted,
        [Description("Overdue and Discounted")]
        OverdueandDiscounted,
        [Description("Overdue")]
        Overdue,
        [Description("Cancelled")]
        Cancelled,
    }

    public enum Isopening
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }

    public enum Cformapplicable
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }


}