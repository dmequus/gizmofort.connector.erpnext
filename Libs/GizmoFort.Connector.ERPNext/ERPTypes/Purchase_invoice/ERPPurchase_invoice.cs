using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_invoice
{
    public class ERPPurchase_invoice : ERPNextObjectBase
    {
        public ERPPurchase_invoice() : this(new ERPObject(DocType.Purchase_invoice)) { }
        public ERPPurchase_invoice(ERPObject obj) : base(obj) { }

        public static ERPPurchase_invoice Create(string title, string namingseries, string supplier, string postingdate, string items, string creditto)

        {
            ERPPurchase_invoice obj = new ERPPurchase_invoice();
            obj.title = title;
            obj.naming_series = namingseries;
            obj.supplier = supplier;
            obj.posting_date = postingdate;
            obj.items = items;
            obj.credit_to = creditto;
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

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        public string credit_to
        {
            get { return data.credit_to; }
            set { data.credit_to = value; }
        }

        public string supplier_name
        {
            get { return data.supplier_name; }
            set { data.supplier_name = value; }
        }

        public string tax_id
        {
            get { return data.tax_id; }
            set { data.tax_id = value; }
        }

        public string due_date
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        private int _is_paid = 0;
        public int is_paid
        {
            get { return data._is_paid; }
            set { data._is_paid = value; }
        }

        private int _is_return = 0;
        public int is_return
        {
            get { return data._is_return; }
            set { data._is_return = value; }
        }

        private int _apply_tds = 0;
        public int apply_tds
        {
            get { return data._apply_tds; }
            set { data._apply_tds = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
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

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        private int _on_hold = 0;
        public int on_hold
        {
            get { return data._on_hold; }
            set { data._on_hold = value; }
        }

        public string release_date
        {
            get { return data.release_date; }
            set { data.release_date = value; }
        }

        public string hold_comment
        {
            get { return data.hold_comment; }
            set { data.hold_comment = value; }
        }

        public string bill_no
        {
            get { return data.bill_no; }
            set { data.bill_no = value; }
        }

        public string bill_date
        {
            get { return data.bill_date; }
            set { data.bill_date = value; }
        }

        public string return_against
        {
            get { return data.return_against; }
            set { data.return_against = value; }
        }

        public string supplier_address
        {
            get { return data.supplier_address; }
            set { data.supplier_address = value; }
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

        public string shipping_address
        {
            get { return data.shipping_address; }
            set { data.shipping_address = value; }
        }

        public string shipping_address_display
        {
            get { return data.shipping_address_display; }
            set { data.shipping_address_display = value; }
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

        public string buying_price_list
        {
            get { return data.buying_price_list; }
            set { data.buying_price_list = value; }
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

        public string rejected_warehouse
        {
            get { return data.rejected_warehouse; }
            set { data.rejected_warehouse = value; }
        }

        public Issubcontracted is_subcontracted
        {
            get { return parseEnum<Issubcontracted>(data.is_subcontracted); }
            set { data.is_subcontracted = value.ToString(); }
        }

        public string supplier_warehouse
        {
            get { return data.supplier_warehouse; }
            set { data.supplier_warehouse = value; }
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

        public string supplied_items
        {
            get { return data.supplied_items; }
            set { data.supplied_items = value; }
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

        private double _base_net_total = 0.0;
        public double base_net_total
        {
            get { return data._base_net_total; }
            set { data._base_net_total = value; }
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

        public string tax_category
        {
            get { return data.tax_category; }
            set { data.tax_category = value; }
        }

        public string shipping_rule
        {
            get { return data.shipping_rule; }
            set { data.shipping_rule = value; }
        }

        public string taxes_and_charges
        {
            get { return data.taxes_and_charges; }
            set { data.taxes_and_charges = value; }
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

        private double _base_taxes_and_charges_added = 0.0;
        public double base_taxes_and_charges_added
        {
            get { return data._base_taxes_and_charges_added; }
            set { data._base_taxes_and_charges_added = value; }
        }

        private double _base_taxes_and_charges_deducted = 0.0;
        public double base_taxes_and_charges_deducted
        {
            get { return data._base_taxes_and_charges_deducted; }
            set { data._base_taxes_and_charges_deducted = value; }
        }

        private double _base_total_taxes_and_charges = 0.0;
        public double base_total_taxes_and_charges
        {
            get { return data._base_total_taxes_and_charges; }
            set { data._base_total_taxes_and_charges = value; }
        }

        private double _taxes_and_charges_added = 0.0;
        public double taxes_and_charges_added
        {
            get { return data._taxes_and_charges_added; }
            set { data._taxes_and_charges_added = value; }
        }

        private double _taxes_and_charges_deducted = 0.0;
        public double taxes_and_charges_deducted
        {
            get { return data._taxes_and_charges_deducted; }
            set { data._taxes_and_charges_deducted = value; }
        }

        private double _total_taxes_and_charges = 0.0;
        public double total_taxes_and_charges
        {
            get { return data._total_taxes_and_charges; }
            set { data._total_taxes_and_charges = value; }
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

        private double _base_grand_total = 0.0;
        public double base_grand_total
        {
            get { return data._base_grand_total; }
            set { data._base_grand_total = value; }
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

        private double _grand_total = 0.0;
        public double grand_total
        {
            get { return data._grand_total; }
            set { data._grand_total = value; }
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

        private int _disable_rounded_total = 0;
        public int disable_rounded_total
        {
            get { return data._disable_rounded_total; }
            set { data._disable_rounded_total = value; }
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
        }

        public string cash_bank_account
        {
            get { return data.cash_bank_account; }
            set { data.cash_bank_account = value; }
        }

        public string clearance_date
        {
            get { return data.clearance_date; }
            set { data.clearance_date = value; }
        }

        private double _paid_amount = 0.0;
        public double paid_amount
        {
            get { return data._paid_amount; }
            set { data._paid_amount = value; }
        }

        private double _base_paid_amount = 0.0;
        public double base_paid_amount
        {
            get { return data._base_paid_amount; }
            set { data._base_paid_amount = value; }
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

        public string select_print_heading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = value; }
        }

        public string language
        {
            get { return data.language; }
            set { data.language = value; }
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

        public string against_expense_account
        {
            get { return data.against_expense_account; }
            set { data.against_expense_account = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string inter_company_invoice_reference
        {
            get { return data.inter_company_invoice_reference; }
            set { data.inter_company_invoice_reference = value; }
        }

        public string remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
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

        private int _is_internal_supplier = 0;
        public int is_internal_supplier
        {
            get { return data._is_internal_supplier; }
            set { data._is_internal_supplier = value; }
        }

        public string tax_withholding_category
        {
            get { return data.tax_withholding_category; }
            set { data.tax_withholding_category = value; }
        }


    }

    //Enums go here
    public enum Issubcontracted
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }

    public enum Applydiscounton
    {
        [Description("Grand Total")]
        GrandTotal,
        [Description("Net Total")]
        NetTotal,
    }

    public enum Isopening
    {
        [Description("No")]
        No,
        [Description("Yes")]
        Yes,
    }

    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Return")]
        Return,
        [Description("Debit Note Issued")]
        DebitNoteIssued,
        [Description("Submitted")]
        Submitted,
        [Description("Paid")]
        Paid,
        [Description("Unpaid")]
        Unpaid,
        [Description("Overdue")]
        Overdue,
        [Description("Cancelled")]
        Cancelled,
    }


}