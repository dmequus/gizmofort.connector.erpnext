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

        public long issue_credit_note
        {
            get { return data.issue_credit_note; }
            set { data.issue_credit_note = value; }
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

        public double per_billed
        {
            get { return data.per_billed; }
            set { data.per_billed = value; }
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

        public long print_without_amount
        {
            get { return data.print_without_amount; }
            set { data.print_without_amount = value; }
        }

        public long group_same_items
        {
            get { return data.group_same_items; }
            set { data.group_same_items = value; }
        }

        public double per_installed
        {
            get { return data.per_installed; }
            set { data.per_installed = value; }
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

        public string pick_list
        {
            get { return data.pick_list; }
            set { data.pick_list = value; }
        }

        public long is_internal_customer
        {
            get { return data.is_internal_customer; }
            set { data.is_internal_customer = value; }
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