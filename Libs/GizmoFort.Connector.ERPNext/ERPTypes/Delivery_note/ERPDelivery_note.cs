using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Delivery_note
{
    public class ERPDelivery_note : ERPNextObjectBase
    {
        public ERPDelivery_note() : this(new ERPObject(DocType.Delivery_note)) { }
        public ERPDelivery_note(ERPObject obj) : base(obj) { }

        public static ERPDelivery_note Create(string title, string namingseries, string customer, string company, string postingdate, string postingtime, string currency, double conversionrate, string sellingpricelist, string pricelistcurrency, double plcconversionrate, string items, Status status)

        {
            ERPDelivery_note obj = new ERPDelivery_note();
            obj.title = title;
            obj.naming_series = namingseries;
            obj.customer = customer;
            obj.company = company;
            obj.posting_date = postingdate;
            obj.posting_time = postingtime;
            obj.currency = currency;
            obj.conversion_rate = conversionrate;
            obj.selling_price_list = sellingpricelist;
            obj.price_list_currency = pricelistcurrency;
            obj.plc_conversion_rate = plcconversionrate;
            obj.items = items;
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

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
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

        public string posting_time
        {
            get { return data.posting_time; }
            set { data.posting_time = value; }
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

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string customer_name
        {
            get { return data.customer_name; }
            set { data.customer_name = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
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

        private int _issue_credit_note = 0;
        public int issue_credit_note
        {
            get { return data._issue_credit_note; }
            set { data._issue_credit_note = value; }
        }

        public string return_against
        {
            get { return data.return_against; }
            set { data.return_against = value; }
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

        public string customer_address
        {
            get { return data.customer_address; }
            set { data.customer_address = value; }
        }

        public string tax_id
        {
            get { return data.tax_id; }
            set { data.tax_id = value; }
        }

        public string address_display
        {
            get { return data.address_display; }
            set { data.address_display = value; }
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

        public string to_warehouse
        {
            get { return data.to_warehouse; }
            set { data.to_warehouse = value; }
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

        public string transporter
        {
            get { return data.transporter; }
            set { data.transporter = value; }
        }

        public string driver
        {
            get { return data.driver; }
            set { data.driver = value; }
        }

        public string lr_no
        {
            get { return data.lr_no; }
            set { data.lr_no = value; }
        }

        public string vehicle_no
        {
            get { return data.vehicle_no; }
            set { data.vehicle_no = value; }
        }

        public string transporter_name
        {
            get { return data.transporter_name; }
            set { data.transporter_name = value; }
        }

        public string driver_name
        {
            get { return data.driver_name; }
            set { data.driver_name = value; }
        }

        public string lr_date
        {
            get { return data.lr_date; }
            set { data.lr_date = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string campaign
        {
            get { return data.campaign; }
            set { data.campaign = value; }
        }

        public string source
        {
            get { return data.source; }
            set { data.source = value; }
        }

        private double _per_billed = 0.0;
        public double per_billed
        {
            get { return data._per_billed; }
            set { data._per_billed = value; }
        }

        public string customer_group
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        public string territory
        {
            get { return data.territory; }
            set { data.territory = value; }
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

        private int _print_without_amount = 0;
        public int print_without_amount
        {
            get { return data._print_without_amount; }
            set { data._print_without_amount = value; }
        }

        private int _group_same_items = 0;
        public int group_same_items
        {
            get { return data._group_same_items; }
            set { data._group_same_items = value; }
        }

        private double _per_installed = 0.0;
        public double per_installed
        {
            get { return data._per_installed; }
            set { data._per_installed = value; }
        }

        public string installation_status
        {
            get { return data.installation_status; }
            set { data.installation_status = value; }
        }

        public string excise_page
        {
            get { return data.excise_page; }
            set { data.excise_page = value; }
        }

        public string instructions
        {
            get { return data.instructions; }
            set { data.instructions = value; }
        }

        public string auto_repeat
        {
            get { return data.auto_repeat; }
            set { data.auto_repeat = value; }
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

        public string pick_list
        {
            get { return data.pick_list; }
            set { data.pick_list = value; }
        }

        private int _is_internal_customer = 0;
        public int is_internal_customer
        {
            get { return data._is_internal_customer; }
            set { data._is_internal_customer = value; }
        }

        public string inter_company_reference
        {
            get { return data.inter_company_reference; }
            set { data.inter_company_reference = value; }
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

    public enum Applydiscounton
    {
        [Description("Grand Total")]
        GrandTotal,
        [Description("Net Total")]
        NetTotal,
    }


}