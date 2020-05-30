using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_quotation
{
    public class ERPSupplier_quotation : ERPNextObjectBase
    {
        public ERPSupplier_quotation() : this(new ERPObject(DocType.Supplier_quotation)) { }
        public ERPSupplier_quotation(ERPObject obj) : base(obj) { }

        public static ERPSupplier_quotation Create(string title, string namingseries, string supplier, string transactiondate, string company, string currency, double conversionrate, string items, Status status)

        {
            ERPSupplier_quotation obj = new ERPSupplier_quotation();
            obj.title = title;
            obj.naming_series = namingseries;
            obj.supplier = supplier;
            obj.transaction_date = transactiondate;
            obj.company = company;
            obj.currency = currency;
            obj.conversion_rate = conversionrate;
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

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public string transaction_date
        {
            get { return data.transaction_date; }
            set { data.transaction_date = value; }
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

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
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

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
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

        public Issubcontracted is_subcontracted
        {
            get { return parseEnum<Issubcontracted>(data.is_subcontracted); }
            set { data.is_subcontracted = value.ToString(); }
        }

        public string opportunity
        {
            get { return data.opportunity; }
            set { data.opportunity = value; }
        }

        public string valid_till
        {
            get { return data.valid_till; }
            set { data.valid_till = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Submitted")]
        Submitted,
        [Description("Stopped")]
        Stopped,
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

    public enum Issubcontracted
    {
        [Description("Yes")]
        Yes,
        [Description("No")]
        No,
    }


}