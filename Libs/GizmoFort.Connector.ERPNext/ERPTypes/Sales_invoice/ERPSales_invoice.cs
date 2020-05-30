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

        public double conversion_rate
        {
            get { return data.conversion_rate; }
            set { data.conversion_rate = value; }
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

        public double plc_conversion_rate
        {
            get { return data.plc_conversion_rate; }
            set { data.plc_conversion_rate = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        public double base_net_total
        {
            get { return data.base_net_total; }
            set { data.base_net_total = value; }
        }

        public double base_grand_total
        {
            get { return data.base_grand_total; }
            set { data.base_grand_total = value; }
        }

        public double grand_total
        {
            get { return data.grand_total; }
            set { data.grand_total = value; }
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

        public long is_pos
        {
            get { return data.is_pos; }
            set { data.is_pos = value; }
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

        public long is_return
        {
            get { return data.is_return; }
            set { data.is_return = value; }
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

        public long seta_posting_time
        {
            get { return data.seta_posting_time; }
            set { data.seta_posting_time = value; }
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

        public long update_billed_amount_in_sales_order
        {
            get { return data.update_billed_amount_in_sales_order; }
            set { data.update_billed_amount_in_sales_order = value; }
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

        public long ignore_pricing_rule
        {
            get { return data.ignore_pricing_rule; }
            set { data.ignore_pricing_rule = value; }
        }

        public string set_warehouse
        {
            get { return data.set_warehouse; }
            set { data.set_warehouse = value; }
        }

        public long update_stock
        {
            get { return data.update_stock; }
            set { data.update_stock = value; }
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

        public double total_billing_amount
        {
            get { return data.total_billing_amount; }
            set { data.total_billing_amount = value; }
        }

        public double total_qty
        {
            get { return data.total_qty; }
            set { data.total_qty = value; }
        }

        public double base_total
        {
            get { return data.base_total; }
            set { data.base_total = value; }
        }

        public double total
        {
            get { return data.total; }
            set { data.total = value; }
        }

        public double net_total
        {
            get { return data.net_total; }
            set { data.net_total = value; }
        }

        public double total_net_weight
        {
            get { return data.total_net_weight; }
            set { data.total_net_weight = value; }
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

        public double base_total_taxes_and_charges
        {
            get { return data.base_total_taxes_and_charges; }
            set { data.base_total_taxes_and_charges = value; }
        }

        public double total_taxes_and_charges
        {
            get { return data.total_taxes_and_charges; }
            set { data.total_taxes_and_charges = value; }
        }

        public int loyalty_points
        {
            get { return data.loyalty_points; }
            set { data.loyalty_points = value; }
        }

        public double loyalty_amount
        {
            get { return data.loyalty_amount; }
            set { data.loyalty_amount = value; }
        }

        public long redeem_loyalty_points
        {
            get { return data.redeem_loyalty_points; }
            set { data.redeem_loyalty_points = value; }
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

        public double base_discount_amount
        {
            get { return data.base_discount_amount; }
            set { data.base_discount_amount = value; }
        }

        public double additional_discount_percentage
        {
            get { return data.additional_discount_percentage; }
            set { data.additional_discount_percentage = value; }
        }

        public double discount_amount
        {
            get { return data.discount_amount; }
            set { data.discount_amount = value; }
        }

        public double base_rounding_adjustment
        {
            get { return data.base_rounding_adjustment; }
            set { data.base_rounding_adjustment = value; }
        }

        public double base_rounded_total
        {
            get { return data.base_rounded_total; }
            set { data.base_rounded_total = value; }
        }

        public string base_in_words
        {
            get { return data.base_in_words; }
            set { data.base_in_words = value; }
        }

        public double rounding_adjustment
        {
            get { return data.rounding_adjustment; }
            set { data.rounding_adjustment = value; }
        }

        public double rounded_total
        {
            get { return data.rounded_total; }
            set { data.rounded_total = value; }
        }

        public string in_words
        {
            get { return data.in_words; }
            set { data.in_words = value; }
        }

        public double total_advance
        {
            get { return data.total_advance; }
            set { data.total_advance = value; }
        }

        public double outstanding_amount
        {
            get { return data.outstanding_amount; }
            set { data.outstanding_amount = value; }
        }

        public long allocate_advances_automatically
        {
            get { return data.allocate_advances_automatically; }
            set { data.allocate_advances_automatically = value; }
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

        public double base_paid_amount
        {
            get { return data.base_paid_amount; }
            set { data.base_paid_amount = value; }
        }

        public double paid_amount
        {
            get { return data.paid_amount; }
            set { data.paid_amount = value; }
        }

        public double base_change_amount
        {
            get { return data.base_change_amount; }
            set { data.base_change_amount = value; }
        }

        public double change_amount
        {
            get { return data.change_amount; }
            set { data.change_amount = value; }
        }

        public string account_for_change_amount
        {
            get { return data.account_for_change_amount; }
            set { data.account_for_change_amount = value; }
        }

        public double write_off_amount
        {
            get { return data.write_off_amount; }
            set { data.write_off_amount = value; }
        }

        public double base_write_off_amount
        {
            get { return data.base_write_off_amount; }
            set { data.base_write_off_amount = value; }
        }

        public long write_off_outstanding_amount_automatically
        {
            get { return data.write_off_outstanding_amount_automatically; }
            set { data.write_off_outstanding_amount_automatically = value; }
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

        public long group_same_items
        {
            get { return data.group_same_items; }
            set { data.group_same_items = value; }
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

        public long is_discounted
        {
            get { return data.is_discounted; }
            set { data.is_discounted = value; }
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

        public double commission_rate
        {
            get { return data.commission_rate; }
            set { data.commission_rate = value; }
        }

        public double total_commission
        {
            get { return data.total_commission; }
            set { data.total_commission = value; }
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

        public double pos_total_qty
        {
            get { return data.pos_total_qty; }
            set { data.pos_total_qty = value; }
        }

        public long is_internal_customer
        {
            get { return data.is_internal_customer; }
            set { data.is_internal_customer = value; }
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