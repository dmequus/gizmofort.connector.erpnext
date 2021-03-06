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

        public string pricing_rules
        {
            get { return data.pricing_rules; }
            set { data.pricing_rules = value; }
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

        public string select_print_heading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = value; }
        }

        public long group_same_items
        {
            get { return data.group_same_items; }
            set { data.group_same_items = value; }
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