using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_receipt
{
    public class ERPPurchase_receipt : ERPNextObjectBase
    {
        public ERPPurchase_receipt() : this(new ERPObject(DocType.Purchase_receipt)) { }
        public ERPPurchase_receipt(ERPObject obj) : base(obj) { }

        public static ERPPurchase_receipt Create(string title, string namingseries, string supplier, string postingdate, string postingtime, string company, string currency, double conversionrate, string items, double basenettotal, Status status)

        {
            ERPPurchase_receipt obj = new ERPPurchase_receipt();
            obj.title = title;
            obj.naming_series = namingseries;
            obj.supplier = supplier;
            obj.posting_date = postingdate;
            obj.posting_time = postingtime;
            obj.company = company;
            obj.currency = currency;
            obj.conversion_rate = conversionrate;
            obj.items = items;
            obj.base_net_total = basenettotal;
            obj.status = status;
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

        public string posting_time
        {
            get { return data.posting_time; }
            set { data.posting_time = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
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

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string supplier_name
        {
            get { return data.supplier_name; }
            set { data.supplier_name = value; }
        }

        public string supplier_delivery_note
        {
            get { return data.supplier_delivery_note; }
            set { data.supplier_delivery_note = value; }
        }

        public long seta_posting_time
        {
            get { return data.seta_posting_time; }
            set { data.seta_posting_time = value; }
        }

        public long is_return
        {
            get { return data.is_return; }
            set { data.is_return = value; }
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

        public string contact_person
        {
            get { return data.contact_person; }
            set { data.contact_person = value; }
        }

        public string address_display
        {
            get { return data.address_display; }
            set { data.address_display = value; }
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

        public string base_in_words
        {
            get { return data.base_in_words; }
            set { data.base_in_words = value; }
        }

        public double base_rounded_total
        {
            get { return data.base_rounded_total; }
            set { data.base_rounded_total = value; }
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

        public long disable_rounded_total
        {
            get { return data.disable_rounded_total; }
            set { data.disable_rounded_total = value; }
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

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string range
        {
            get { return data.range; }
            set { data.range = value; }
        }

        public double per_billed
        {
            get { return data.per_billed; }
            set { data.per_billed = value; }
        }

        public string auto_repeat
        {
            get { return data.auto_repeat; }
            set { data.auto_repeat = value; }
        }

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
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

        public long group_same_items
        {
            get { return data.group_same_items; }
            set { data.group_same_items = value; }
        }

        public string other_details
        {
            get { return data.other_details; }
            set { data.other_details = value; }
        }

        public string instructions
        {
            get { return data.instructions; }
            set { data.instructions = value; }
        }

        public string remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        public string transporter_name
        {
            get { return data.transporter_name; }
            set { data.transporter_name = value; }
        }

        public string lr_no
        {
            get { return data.lr_no; }
            set { data.lr_no = value; }
        }

        public string lr_date
        {
            get { return data.lr_date; }
            set { data.lr_date = value; }
        }

        public long is_internal_supplier
        {
            get { return data.is_internal_supplier; }
            set { data.is_internal_supplier = value; }
        }

        public string inter_company_reference
        {
            get { return data.inter_company_reference; }
            set { data.inter_company_reference = value; }
        }

        public string scan_barcode
        {
            get { return data.scan_barcode; }
            set { data.scan_barcode = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("To Bill")]
        ToBill,
        [Description("Completed")]
        Completed,
        [Description("Cancelled")]
        Cancelled,
        [Description("Closed")]
        Closed,
    }

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


}