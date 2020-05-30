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

        private double _conversion_rate = 0.0;
        public double conversion_rate
        {
            get { return data._conversion_rate; }
            set { data._conversion_rate = value; }
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

        private int _seta_posting_time = 0;
        public int seta_posting_time
        {
            get { return data._seta_posting_time; }
            set { data._seta_posting_time = value; }
        }

        private int _is_return = 0;
        public int is_return
        {
            get { return data._is_return; }
            set { data._is_return = value; }
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

        public string base_in_words
        {
            get { return data.base_in_words; }
            set { data.base_in_words = value; }
        }

        private double _base_rounded_total = 0.0;
        public double base_rounded_total
        {
            get { return data._base_rounded_total; }
            set { data._base_rounded_total = value; }
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

        private int _disable_rounded_total = 0;
        public int disable_rounded_total
        {
            get { return data._disable_rounded_total; }
            set { data._disable_rounded_total = value; }
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

        private double _per_billed = 0.0;
        public double per_billed
        {
            get { return data._per_billed; }
            set { data._per_billed = value; }
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

        private int _group_same_items = 0;
        public int group_same_items
        {
            get { return data._group_same_items; }
            set { data._group_same_items = value; }
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

        private int _is_internal_supplier = 0;
        public int is_internal_supplier
        {
            get { return data._is_internal_supplier; }
            set { data._is_internal_supplier = value; }
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