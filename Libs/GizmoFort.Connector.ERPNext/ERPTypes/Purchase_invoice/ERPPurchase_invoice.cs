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

        public long is_paid
        {
            get { return data.is_paid; }
            set { data.is_paid = value; }
        }

        public long is_return
        {
            get { return data.is_return; }
            set { data.is_return = value; }
        }

        public long apply_tds
        {
            get { return data.apply_tds; }
            set { data.apply_tds = value; }
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

        public long seta_posting_time
        {
            get { return data.seta_posting_time; }
            set { data.seta_posting_time = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public long on_hold
        {
            get { return data.on_hold; }
            set { data.on_hold = value; }
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

        public double conversion_rate
        {
            get { return data.conversion_rate; }
            set { data.conversion_rate = value; }
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

        public double plc_conversion_rate
        {
            get { return data.plc_conversion_rate; }
            set { data.plc_conversion_rate = value; }
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

        public string supplied_items
        {
            get { return data.supplied_items; }
            set { data.supplied_items = value; }
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

        public double base_net_total
        {
            get { return data.base_net_total; }
            set { data.base_net_total = value; }
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

        public double base_taxes_and_charges_added
        {
            get { return data.base_taxes_and_charges_added; }
            set { data.base_taxes_and_charges_added = value; }
        }

        public double base_taxes_and_charges_deducted
        {
            get { return data.base_taxes_and_charges_deducted; }
            set { data.base_taxes_and_charges_deducted = value; }
        }

        public double base_total_taxes_and_charges
        {
            get { return data.base_total_taxes_and_charges; }
            set { data.base_total_taxes_and_charges = value; }
        }

        public double taxes_and_charges_added
        {
            get { return data.taxes_and_charges_added; }
            set { data.taxes_and_charges_added = value; }
        }

        public double taxes_and_charges_deducted
        {
            get { return data.taxes_and_charges_deducted; }
            set { data.taxes_and_charges_deducted = value; }
        }

        public double total_taxes_and_charges
        {
            get { return data.total_taxes_and_charges; }
            set { data.total_taxes_and_charges = value; }
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

        public double base_grand_total
        {
            get { return data.base_grand_total; }
            set { data.base_grand_total = value; }
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

        public double grand_total
        {
            get { return data.grand_total; }
            set { data.grand_total = value; }
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

        public long disable_rounded_total
        {
            get { return data.disable_rounded_total; }
            set { data.disable_rounded_total = value; }
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

        public double paid_amount
        {
            get { return data.paid_amount; }
            set { data.paid_amount = value; }
        }

        public double base_paid_amount
        {
            get { return data.base_paid_amount; }
            set { data.base_paid_amount = value; }
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

        public long is_internal_supplier
        {
            get { return data.is_internal_supplier; }
            set { data.is_internal_supplier = value; }
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