using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_order
{
    public class ERPSales_order : ERPNextObjectBase
    {
        public ERPSales_order() : this(new ERPObject(DocType.Sales_order)) { }
        public ERPSales_order(ERPObject obj) : base(obj) { }

        public static ERPSales_order Create(string title, string namingseries, string customer, Ordertype ordertype, string company, string transactiondate, string currency, double conversionrate, string sellingpricelist, string pricelistcurrency, double plcconversionrate, string items, Status status)

        {
            ERPSales_order obj = new ERPSales_order();
            obj.title = title;
            obj.naming_series = namingseries;
            obj.customer = customer;
            obj.order_type = ordertype;
            obj.company = company;
            obj.transaction_date = transactiondate;
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

        public Ordertype order_type
        {
            get { return parseEnum<Ordertype>(data.order_type); }
            set { data.order_type = value.ToString(); }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string transaction_date
        {
            get { return data.transaction_date; }
            set { data.transaction_date = value; }
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

        public string delivery_date
        {
            get { return data.delivery_date; }
            set { data.delivery_date = value; }
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

        public string tax_id
        {
            get { return data.tax_id; }
            set { data.tax_id = value; }
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

        public string company_address_display
        {
            get { return data.company_address_display; }
            set { data.company_address_display = value; }
        }

        public string company_address
        {
            get { return data.company_address; }
            set { data.company_address = value; }
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

        public string coupon_code
        {
            get { return data.coupon_code; }
            set { data.coupon_code = value; }
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

        private double _advance_paid = 0.0;
        public double advance_paid
        {
            get { return data._advance_paid; }
            set { data._advance_paid = value; }
        }

        public string packed_items
        {
            get { return data.packed_items; }
            set { data.packed_items = value; }
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

        public string inter_company_order_reference
        {
            get { return data.inter_company_order_reference; }
            set { data.inter_company_order_reference = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string party_account_currency
        {
            get { return data.party_account_currency; }
            set { data.party_account_currency = value; }
        }

        public string source
        {
            get { return data.source; }
            set { data.source = value; }
        }

        public string campaign
        {
            get { return data.campaign; }
            set { data.campaign = value; }
        }

        public string language
        {
            get { return data.language; }
            set { data.language = value; }
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

        private int _group_same_items = 0;
        public int group_same_items
        {
            get { return data._group_same_items; }
            set { data._group_same_items = value; }
        }

        public Deliverystatus delivery_status
        {
            get { return parseEnum<Deliverystatus>(data.delivery_status); }
            set { data.delivery_status = value.ToString(); }
        }

        private double _per_delivered = 0.0;
        public double per_delivered
        {
            get { return data._per_delivered; }
            set { data._per_delivered = value; }
        }

        private double _per_billed = 0.0;
        public double per_billed
        {
            get { return data._per_billed; }
            set { data._per_billed = value; }
        }

        public Billingstatus billing_status
        {
            get { return parseEnum<Billingstatus>(data.billing_status); }
            set { data.billing_status = value.ToString(); }
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

        public string contact_phone
        {
            get { return data.contact_phone; }
            set { data.contact_phone = value; }
        }

        private int _skip_delivery_note = 0;
        public int skip_delivery_note
        {
            get { return data._skip_delivery_note; }
            set { data._skip_delivery_note = value; }
        }


    }

    //Enums go here
    public enum Ordertype
    {
        [Description("Sales")]
        Sales,
        [Description("Maintenance")]
        Maintenance,
        [Description("Shopping Cart")]
        ShoppingCart,
    }

    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("On Hold")]
        OnHold,
        [Description("To Deliver and Bill")]
        ToDeliverandBill,
        [Description("To Bill")]
        ToBill,
        [Description("To Deliver")]
        ToDeliver,
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

    public enum Deliverystatus
    {
        [Description("Not Delivered")]
        NotDelivered,
        [Description("Fully Delivered")]
        FullyDelivered,
        [Description("Partly Delivered")]
        PartlyDelivered,
        [Description("Closed")]
        Closed,
        [Description("Not Applicable")]
        NotApplicable,
    }

    public enum Billingstatus
    {
        [Description("Not Billed")]
        NotBilled,
        [Description("Fully Billed")]
        FullyBilled,
        [Description("Partly Billed")]
        PartlyBilled,
        [Description("Closed")]
        Closed,
    }


}