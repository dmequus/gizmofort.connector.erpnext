using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item
{
    public class ERPItem : ERPNextObjectBase
    {
        public ERPItem() : this(new ERPObject(DocType.Item)) { }
        public ERPItem(ERPObject obj) : base(obj) { }

        public static ERPItem Create(string itemname, string itemcode, string itemgroup, string stockuom)

        {
            ERPItem obj = new ERPItem();
            obj.item_name = itemname;
            obj.item_code = itemcode;
            obj.item_group = itemgroup;
            obj.stock_uom = stockuom;
            return obj;
        }

        public string item_name
        {
            get { return data.item_name; }
            set
            {
                data.item_name = value;
                data.name = value;
            }

        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string item_group
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string variant_of
        {
            get { return data.variant_of; }
            set { data.variant_of = value; }
        }

        private int _is_item_from_hub = 0;
        public int is_item_from_hub
        {
            get { return data._is_item_from_hub; }
            set { data._is_item_from_hub = value; }
        }

        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
        }

        private int _allow_alternative_item = 0;
        public int allow_alternative_item
        {
            get { return data._allow_alternative_item; }
            set { data._allow_alternative_item = value; }
        }

        private int _is_stock_item = 0;
        public int is_stock_item
        {
            get { return data._is_stock_item; }
            set { data._is_stock_item = value; }
        }

        private int _include_item_in_manufacturing = 0;
        public int include_item_in_manufacturing
        {
            get { return data._include_item_in_manufacturing; }
            set { data._include_item_in_manufacturing = value; }
        }

        private double _opening_stock = 0.0;
        public double opening_stock
        {
            get { return data._opening_stock; }
            set { data._opening_stock = value; }
        }

        private double _valuation_rate = 0.0;
        public double valuation_rate
        {
            get { return data._valuation_rate; }
            set { data._valuation_rate = value; }
        }

        private double _standard_rate = 0.0;
        public double standard_rate
        {
            get { return data._standard_rate; }
            set { data._standard_rate = value; }
        }

        private int _is_fixed_asset = 0;
        public int is_fixed_asset
        {
            get { return data._is_fixed_asset; }
            set { data._is_fixed_asset = value; }
        }

        public string asset_category
        {
            get { return data.asset_category; }
            set { data.asset_category = value; }
        }

        public string asset_naming_series
        {
            get { return data.asset_naming_series; }
            set { data.asset_naming_series = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string brand
        {
            get { return data.brand; }
            set { data.brand = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string barcodes
        {
            get { return data.barcodes; }
            set { data.barcodes = value; }
        }

        private int _shelf_life_in_days = 0;
        public int shelf_life_in_days
        {
            get { return data._shelf_life_in_days; }
            set { data._shelf_life_in_days = value; }
        }

        public string end_of_life
        {
            get { return data.end_of_life; }
            set { data.end_of_life = value; }
        }

        public Defaultmaterialrequesttype default_material_request_type
        {
            get { return parseEnum<Defaultmaterialrequesttype>(data.default_material_request_type); }
            set { data.default_material_request_type = value.ToString(); }
        }

        public Valuationmethod valuation_method
        {
            get { return parseEnum<Valuationmethod>(data.valuation_method); }
            set { data.valuation_method = value.ToString(); }
        }

        public string warranty_period
        {
            get { return data.warranty_period; }
            set { data.warranty_period = value; }
        }

        private double _weight_per_unit = 0.0;
        public double weight_per_unit
        {
            get { return data._weight_per_unit; }
            set { data._weight_per_unit = value; }
        }

        public string weight_uom
        {
            get { return data.weight_uom; }
            set { data.weight_uom = value; }
        }

        public string reorder_levels
        {
            get { return data.reorder_levels; }
            set { data.reorder_levels = value; }
        }

        public string uoms
        {
            get { return data.uoms; }
            set { data.uoms = value; }
        }

        private int _has_batch_no = 0;
        public int has_batch_no
        {
            get { return data._has_batch_no; }
            set { data._has_batch_no = value; }
        }

        private int _create_new_batch = 0;
        public int create_new_batch
        {
            get { return data._create_new_batch; }
            set { data._create_new_batch = value; }
        }

        public string batch_number_series
        {
            get { return data.batch_number_series; }
            set { data.batch_number_series = value; }
        }

        private int _has_expiry_date = 0;
        public int has_expiry_date
        {
            get { return data._has_expiry_date; }
            set { data._has_expiry_date = value; }
        }

        private int _retain_sample = 0;
        public int retain_sample
        {
            get { return data._retain_sample; }
            set { data._retain_sample = value; }
        }

        private int _sample_quantity = 0;
        public int sample_quantity
        {
            get { return data._sample_quantity; }
            set { data._sample_quantity = value; }
        }

        private int _has_serial_no = 0;
        public int has_serial_no
        {
            get { return data._has_serial_no; }
            set { data._has_serial_no = value; }
        }

        public string serial_no_series
        {
            get { return data.serial_no_series; }
            set { data.serial_no_series = value; }
        }

        private int _has_variants = 0;
        public int has_variants
        {
            get { return data._has_variants; }
            set { data._has_variants = value; }
        }

        public Variantbasedon variant_based_on
        {
            get { return parseEnum<Variantbasedon>(data.variant_based_on); }
            set { data.variant_based_on = value.ToString(); }
        }

        public string attributes
        {
            get { return data.attributes; }
            set { data.attributes = value; }
        }

        public string item_defaults
        {
            get { return data.item_defaults; }
            set { data.item_defaults = value; }
        }

        private int _is_purchase_item = 0;
        public int is_purchase_item
        {
            get { return data._is_purchase_item; }
            set { data._is_purchase_item = value; }
        }

        public string purchase_uom
        {
            get { return data.purchase_uom; }
            set { data.purchase_uom = value; }
        }

        private double _min_order_qty = 0.0;
        public double min_order_qty
        {
            get { return data._min_order_qty; }
            set { data._min_order_qty = value; }
        }

        private double _safety_stock = 0.0;
        public double safety_stock
        {
            get { return data._safety_stock; }
            set { data._safety_stock = value; }
        }

        private int _lead_time_days = 0;
        public int lead_time_days
        {
            get { return data._lead_time_days; }
            set { data._lead_time_days = value; }
        }

        private double _last_purchase_rate = 0.0;
        public double last_purchase_rate
        {
            get { return data._last_purchase_rate; }
            set { data._last_purchase_rate = value; }
        }

        private int _is_customer_provided_item = 0;
        public int is_customer_provided_item
        {
            get { return data._is_customer_provided_item; }
            set { data._is_customer_provided_item = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        private int _delivered_by_supplier = 0;
        public int delivered_by_supplier
        {
            get { return data._delivered_by_supplier; }
            set { data._delivered_by_supplier = value; }
        }

        public string supplier_items
        {
            get { return data.supplier_items; }
            set { data.supplier_items = value; }
        }

        public string country_of_origin
        {
            get { return data.country_of_origin; }
            set { data.country_of_origin = value; }
        }

        public string customs_tariff_number
        {
            get { return data.customs_tariff_number; }
            set { data.customs_tariff_number = value; }
        }

        public string sales_uom
        {
            get { return data.sales_uom; }
            set { data.sales_uom = value; }
        }

        private int _is_sales_item = 0;
        public int is_sales_item
        {
            get { return data._is_sales_item; }
            set { data._is_sales_item = value; }
        }

        private double _max_discount = 0.0;
        public double max_discount
        {
            get { return data._max_discount; }
            set { data._max_discount = value; }
        }

        public string deferred_revenue_account
        {
            get { return data.deferred_revenue_account; }
            set { data.deferred_revenue_account = value; }
        }

        private int _enable_deferred_revenue = 0;
        public int enable_deferred_revenue
        {
            get { return data._enable_deferred_revenue; }
            set { data._enable_deferred_revenue = value; }
        }

        private int _no_of_months = 0;
        public int no_of_months
        {
            get { return data._no_of_months; }
            set { data._no_of_months = value; }
        }

        public string deferred_expense_account
        {
            get { return data.deferred_expense_account; }
            set { data.deferred_expense_account = value; }
        }

        private int _enable_deferred_expense = 0;
        public int enable_deferred_expense
        {
            get { return data._enable_deferred_expense; }
            set { data._enable_deferred_expense = value; }
        }

        private int _no_of_months_exp = 0;
        public int no_of_months_exp
        {
            get { return data._no_of_months_exp; }
            set { data._no_of_months_exp = value; }
        }

        public string customer_items
        {
            get { return data.customer_items; }
            set { data.customer_items = value; }
        }

        public string taxes
        {
            get { return data.taxes; }
            set { data.taxes = value; }
        }

        private int _inspection_required_before_purchase = 0;
        public int inspection_required_before_purchase
        {
            get { return data._inspection_required_before_purchase; }
            set { data._inspection_required_before_purchase = value; }
        }

        private int _inspection_required_before_delivery = 0;
        public int inspection_required_before_delivery
        {
            get { return data._inspection_required_before_delivery; }
            set { data._inspection_required_before_delivery = value; }
        }

        public string quality_inspection_template
        {
            get { return data.quality_inspection_template; }
            set { data.quality_inspection_template = value; }
        }

        public string default_bom
        {
            get { return data.default_bom; }
            set { data.default_bom = value; }
        }

        private int _is_sub_contracted_item = 0;
        public int is_sub_contracted_item
        {
            get { return data._is_sub_contracted_item; }
            set { data._is_sub_contracted_item = value; }
        }

        public string customer_code
        {
            get { return data.customer_code; }
            set { data.customer_code = value; }
        }

        private int _show_in_website = 0;
        public int show_in_website
        {
            get { return data._show_in_website; }
            set { data._show_in_website = value; }
        }

        private int _show_variant_in_website = 0;
        public int show_variant_in_website
        {
            get { return data._show_variant_in_website; }
            set { data._show_variant_in_website = value; }
        }

        public string route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        private int _weightage = 0;
        public int weightage
        {
            get { return data._weightage; }
            set { data._weightage = value; }
        }

        public string slideshow
        {
            get { return data.slideshow; }
            set { data.slideshow = value; }
        }

        public string website_image
        {
            get { return data.website_image; }
            set { data.website_image = value; }
        }

        public string thumbnail
        {
            get { return data.thumbnail; }
            set { data.thumbnail = value; }
        }

        public string website_warehouse
        {
            get { return data.website_warehouse; }
            set { data.website_warehouse = value; }
        }

        public string website_item_groups
        {
            get { return data.website_item_groups; }
            set { data.website_item_groups = value; }
        }

        public string website_specifications
        {
            get { return data.website_specifications; }
            set { data.website_specifications = value; }
        }

        public string web_long_description
        {
            get { return data.web_long_description; }
            set { data.web_long_description = value; }
        }

        public string website_content
        {
            get { return data.website_content; }
            set { data.website_content = value; }
        }

        private double _total_projected_qty = 0.0;
        public double total_projected_qty
        {
            get { return data._total_projected_qty; }
            set { data._total_projected_qty = value; }
        }

        private int _publish_in_hub = 0;
        public int publish_in_hub
        {
            get { return data._publish_in_hub; }
            set { data._publish_in_hub = value; }
        }

        public string hub_category_to_publish
        {
            get { return data.hub_category_to_publish; }
            set { data.hub_category_to_publish = value; }
        }

        public string hub_warehouse
        {
            get { return data.hub_warehouse; }
            set { data.hub_warehouse = value; }
        }

        private int _synced_with_hub = 0;
        public int synced_with_hub
        {
            get { return data._synced_with_hub; }
            set { data._synced_with_hub = value; }
        }

        private double _over_delivery_receipt_allowance = 0.0;
        public double over_delivery_receipt_allowance
        {
            get { return data._over_delivery_receipt_allowance; }
            set { data._over_delivery_receipt_allowance = value; }
        }

        private double _over_billing_allowance = 0.0;
        public double over_billing_allowance
        {
            get { return data._over_billing_allowance; }
            set { data._over_billing_allowance = value; }
        }

        private int _auto_create_assets = 0;
        public int auto_create_assets
        {
            get { return data._auto_create_assets; }
            set { data._auto_create_assets = value; }
        }

        public string default_item_manufacturer
        {
            get { return data.default_item_manufacturer; }
            set { data.default_item_manufacturer = value; }
        }

        public string default_manufacturer_part_no
        {
            get { return data.default_manufacturer_part_no; }
            set { data.default_manufacturer_part_no = value; }
        }


    }

    //Enums go here
    public enum Defaultmaterialrequesttype
    {
        [Description("Purchase")]
        Purchase,
        [Description("Material Transfer")]
        MaterialTransfer,
        [Description("Material Issue")]
        MaterialIssue,
        [Description("Manufacture")]
        Manufacture,
        [Description("Customer Provided")]
        CustomerProvided,
    }

    public enum Valuationmethod
    {
        [Description("FIFO")]
        FIFO,
        [Description("Moving Average")]
        MovingAverage,
    }

    public enum Variantbasedon
    {
        [Description("Item Attribute")]
        ItemAttribute,
        [Description("Manufacturer")]
        Manufacturer,
    }


}