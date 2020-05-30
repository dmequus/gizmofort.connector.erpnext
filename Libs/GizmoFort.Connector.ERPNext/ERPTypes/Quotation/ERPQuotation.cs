using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Quotation
{
    public class ERPQuotation : ERPNextObjectBase
    {
        public ERPQuotation() : this(new ERPObject(DocType.Quotation)) { }
        public ERPQuotation(ERPObject obj) : base(obj) { }

        public static ERPQuotation Create(string title, string namingseries, string quotationto, string company, string transactiondate, Ordertype ordertype, string currency, double conversionrate, string sellingpricelist, string pricelistcurrency, double plcconversionrate, string items, Status status)

        {
            ERPQuotation obj = new ERPQuotation();
            obj.title = title;
            obj.naming_series = namingseries;
            obj.quotation_to = quotationto;
            obj.company = company;
            obj.transaction_date = transactiondate;
            obj.order_type = ordertype;
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

        public string quotation_to
        {
            get { return data.quotation_to; }
            set { data.quotation_to = value; }
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

        public Ordertype order_type
        {
            get { return parseEnum<Ordertype>(data.order_type); }
            set { data.order_type = value.ToString(); }
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

        public string party_name
        {
            get { return data.party_name; }
            set { data.party_name = value; }
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

        public string valid_till
        {
            get { return data.valid_till; }
            set { data.valid_till = value; }
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

        public string coupon_code
        {
            get { return data.coupon_code; }
            set { data.coupon_code = value; }
        }

        public string referral_sales_partner
        {
            get { return data.referral_sales_partner; }
            set { data.referral_sales_partner = value; }
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

        public string auto_repeat
        {
            get { return data.auto_repeat; }
            set { data.auto_repeat = value; }
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

        public string order_lost_reason
        {
            get { return data.order_lost_reason; }
            set { data.order_lost_reason = value; }
        }

        public string enq_det
        {
            get { return data.enq_det; }
            set { data.enq_det = value; }
        }

        public string supplier_quotation
        {
            get { return data.supplier_quotation; }
            set { data.supplier_quotation = value; }
        }

        public string opportunity
        {
            get { return data.opportunity; }
            set { data.opportunity = value; }
        }

        public string lost_reasons
        {
            get { return data.lost_reasons; }
            set { data.lost_reasons = value; }
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
        [Description("Open")]
        Open,
        [Description("Replied")]
        Replied,
        [Description("Ordered")]
        Ordered,
        [Description("Lost")]
        Lost,
        [Description("Cancelled")]
        Cancelled,
        [Description("Expired")]
        Expired,
    }

    public enum Applydiscounton
    {
        [Description("Grand Total")]
        GrandTotal,
        [Description("Net Total")]
        NetTotal,
    }


}