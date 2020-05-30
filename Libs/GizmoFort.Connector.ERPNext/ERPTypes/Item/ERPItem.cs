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

        public long is_item_from_hub
        {
            get { return data.is_item_from_hub; }
            set { data.is_item_from_hub = value; }
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        public long allow_alternative_item
        {
            get { return data.allow_alternative_item; }
            set { data.allow_alternative_item = value; }
        }

        public long is_stock_item
        {
            get { return data.is_stock_item; }
            set { data.is_stock_item = value; }
        }

        public long include_item_in_manufacturing
        {
            get { return data.include_item_in_manufacturing; }
            set { data.include_item_in_manufacturing = value; }
        }

        public double opening_stock
        {
            get { return data.opening_stock; }
            set { data.opening_stock = value; }
        }

        public double valuation_rate
        {
            get { return data.valuation_rate; }
            set { data.valuation_rate = value; }
        }

        public double standard_rate
        {
            get { return data.standard_rate; }
            set { data.standard_rate = value; }
        }

        public long is_fixed_asset
        {
            get { return data.is_fixed_asset; }
            set { data.is_fixed_asset = value; }
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

        public int shelf_life_in_days
        {
            get { return data.shelf_life_in_days; }
            set { data.shelf_life_in_days = value; }
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

        public double weight_per_unit
        {
            get { return data.weight_per_unit; }
            set { data.weight_per_unit = value; }
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

        public long has_batch_no
        {
            get { return data.has_batch_no; }
            set { data.has_batch_no = value; }
        }

        public long create_new_batch
        {
            get { return data.create_new_batch; }
            set { data.create_new_batch = value; }
        }

        public string batch_number_series
        {
            get { return data.batch_number_series; }
            set { data.batch_number_series = value; }
        }

        public long has_expiry_date
        {
            get { return data.has_expiry_date; }
            set { data.has_expiry_date = value; }
        }

        public long retain_sample
        {
            get { return data.retain_sample; }
            set { data.retain_sample = value; }
        }

        public int sample_quantity
        {
            get { return data.sample_quantity; }
            set { data.sample_quantity = value; }
        }

        public long has_serial_no
        {
            get { return data.has_serial_no; }
            set { data.has_serial_no = value; }
        }

        public string serial_no_series
        {
            get { return data.serial_no_series; }
            set { data.serial_no_series = value; }
        }

        public long has_variants
        {
            get { return data.has_variants; }
            set { data.has_variants = value; }
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

        public long is_purchase_item
        {
            get { return data.is_purchase_item; }
            set { data.is_purchase_item = value; }
        }

        public string purchase_uom
        {
            get { return data.purchase_uom; }
            set { data.purchase_uom = value; }
        }

        public double min_order_qty
        {
            get { return data.min_order_qty; }
            set { data.min_order_qty = value; }
        }

        public double safety_stock
        {
            get { return data.safety_stock; }
            set { data.safety_stock = value; }
        }

        public int lead_time_days
        {
            get { return data.lead_time_days; }
            set { data.lead_time_days = value; }
        }

        public double last_purchase_rate
        {
            get { return data.last_purchase_rate; }
            set { data.last_purchase_rate = value; }
        }

        public long is_customer_provided_item
        {
            get { return data.is_customer_provided_item; }
            set { data.is_customer_provided_item = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public long delivered_by_supplier
        {
            get { return data.delivered_by_supplier; }
            set { data.delivered_by_supplier = value; }
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

        public long is_sales_item
        {
            get { return data.is_sales_item; }
            set { data.is_sales_item = value; }
        }

        public double max_discount
        {
            get { return data.max_discount; }
            set { data.max_discount = value; }
        }

        public string deferred_revenue_account
        {
            get { return data.deferred_revenue_account; }
            set { data.deferred_revenue_account = value; }
        }

        public long enable_deferred_revenue
        {
            get { return data.enable_deferred_revenue; }
            set { data.enable_deferred_revenue = value; }
        }

        public int no_of_months
        {
            get { return data.no_of_months; }
            set { data.no_of_months = value; }
        }

        public string deferred_expense_account
        {
            get { return data.deferred_expense_account; }
            set { data.deferred_expense_account = value; }
        }

        public long enable_deferred_expense
        {
            get { return data.enable_deferred_expense; }
            set { data.enable_deferred_expense = value; }
        }

        public int no_of_months_exp
        {
            get { return data.no_of_months_exp; }
            set { data.no_of_months_exp = value; }
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

        public long inspection_required_before_purchase
        {
            get { return data.inspection_required_before_purchase; }
            set { data.inspection_required_before_purchase = value; }
        }

        public long inspection_required_before_delivery
        {
            get { return data.inspection_required_before_delivery; }
            set { data.inspection_required_before_delivery = value; }
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

        public long is_sub_contracted_item
        {
            get { return data.is_sub_contracted_item; }
            set { data.is_sub_contracted_item = value; }
        }

        public string customer_code
        {
            get { return data.customer_code; }
            set { data.customer_code = value; }
        }

        public long show_in_website
        {
            get { return data.show_in_website; }
            set { data.show_in_website = value; }
        }

        public long show_variant_in_website
        {
            get { return data.show_variant_in_website; }
            set { data.show_variant_in_website = value; }
        }

        public string route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        public int weightage
        {
            get { return data.weightage; }
            set { data.weightage = value; }
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

        public double total_projected_qty
        {
            get { return data.total_projected_qty; }
            set { data.total_projected_qty = value; }
        }

        public long publish_in_hub
        {
            get { return data.publish_in_hub; }
            set { data.publish_in_hub = value; }
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

        public long synced_with_hub
        {
            get { return data.synced_with_hub; }
            set { data.synced_with_hub = value; }
        }

        public double over_delivery_receipt_allowance
        {
            get { return data.over_delivery_receipt_allowance; }
            set { data.over_delivery_receipt_allowance = value; }
        }

        public double over_billing_allowance
        {
            get { return data.over_billing_allowance; }
            set { data.over_billing_allowance = value; }
        }

        public long auto_create_assets
        {
            get { return data.auto_create_assets; }
            set { data.auto_create_assets = value; }
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