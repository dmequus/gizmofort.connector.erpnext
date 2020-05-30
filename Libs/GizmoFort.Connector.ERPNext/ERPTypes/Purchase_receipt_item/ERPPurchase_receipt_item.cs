using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_receipt_item
{
    public class ERPPurchase_receipt_item : ERPNextObjectBase
    {
        public ERPPurchase_receipt_item() : this(new ERPObject(DocType.Purchase_receipt_item)) { }
        public ERPPurchase_receipt_item(ERPObject obj) : base(obj) { }

        public static ERPPurchase_receipt_item Create(string itemcode, string itemname, string description, double receivedqty, string uom, string stockuom, double conversionfactor, double baserate)

        {
            ERPPurchase_receipt_item obj = new ERPPurchase_receipt_item();
            obj.item_code = itemcode;
            obj.item_name = itemname;
            obj.description = description;
            obj.received_qty = receivedqty;
            obj.uom = uom;
            obj.stock_uom = stockuom;
            obj.conversion_factor = conversionfactor;
            obj.base_rate = baserate;
            return obj;
        }

        public string item_code
        {
            get { return data.item_code; }
            set
            {
                data.item_code = value;
                data.name = value;
            }

        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public double received_qty
        {
            get { return data.received_qty; }
            set { data.received_qty = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        public double conversion_factor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
        }

        public double base_rate
        {
            get { return data.base_rate; }
            set { data.base_rate = value; }
        }

        public string barcode
        {
            get { return data.barcode; }
            set { data.barcode = value; }
        }

        public string supplier_part_no
        {
            get { return data.supplier_part_no; }
            set { data.supplier_part_no = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string image_view
        {
            get { return data.image_view; }
            set { data.image_view = value; }
        }

        public double qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        public double rejected_qty
        {
            get { return data.rejected_qty; }
            set { data.rejected_qty = value; }
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

        public double price_list_rate
        {
            get { return data.price_list_rate; }
            set { data.price_list_rate = value; }
        }

        public double discount_percentage
        {
            get { return data.discount_percentage; }
            set { data.discount_percentage = value; }
        }

        public double discount_amount
        {
            get { return data.discount_amount; }
            set { data.discount_amount = value; }
        }

        public double base_price_list_rate
        {
            get { return data.base_price_list_rate; }
            set { data.base_price_list_rate = value; }
        }

        public double rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        public double base_amount
        {
            get { return data.base_amount; }
            set { data.base_amount = value; }
        }

        public string pricing_rules
        {
            get { return data.pricing_rules; }
            set { data.pricing_rules = value; }
        }

        public long is_free_item
        {
            get { return data.is_free_item; }
            set { data.is_free_item = value; }
        }

        public double net_rate
        {
            get { return data.net_rate; }
            set { data.net_rate = value; }
        }

        public double net_amount
        {
            get { return data.net_amount; }
            set { data.net_amount = value; }
        }

        public double base_net_rate
        {
            get { return data.base_net_rate; }
            set { data.base_net_rate = value; }
        }

        public double base_net_amount
        {
            get { return data.base_net_amount; }
            set { data.base_net_amount = value; }
        }

        public double weight_per_unit
        {
            get { return data.weight_per_unit; }
            set { data.weight_per_unit = value; }
        }

        public double total_weight
        {
            get { return data.total_weight; }
            set { data.total_weight = value; }
        }

        public string weight_uom
        {
            get { return data.weight_uom; }
            set { data.weight_uom = value; }
        }

        public string warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        public string rejected_warehouse
        {
            get { return data.rejected_warehouse; }
            set { data.rejected_warehouse = value; }
        }

        public string quality_inspection
        {
            get { return data.quality_inspection; }
            set { data.quality_inspection = value; }
        }

        public long is_fixed_asset
        {
            get { return data.is_fixed_asset; }
            set { data.is_fixed_asset = value; }
        }

        public string purchase_order
        {
            get { return data.purchase_order; }
            set { data.purchase_order = value; }
        }

        public string schedule_date
        {
            get { return data.schedule_date; }
            set { data.schedule_date = value; }
        }

        public double stock_qty
        {
            get { return data.stock_qty; }
            set { data.stock_qty = value; }
        }

        public string serial_no
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        public string batch_no
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }

        public string rejected_serial_no
        {
            get { return data.rejected_serial_no; }
            set { data.rejected_serial_no = value; }
        }

        public string item_tax_template
        {
            get { return data.item_tax_template; }
            set { data.item_tax_template = value; }
        }

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string purchase_order_item
        {
            get { return data.purchase_order_item; }
            set { data.purchase_order_item = value; }
        }

        public long allow_zero_valuation_rate
        {
            get { return data.allow_zero_valuation_rate; }
            set { data.allow_zero_valuation_rate = value; }
        }

        public string bom
        {
            get { return data.bom; }
            set { data.bom = value; }
        }

        public long include_exploded_items
        {
            get { return data.include_exploded_items; }
            set { data.include_exploded_items = value; }
        }

        public double billed_amt
        {
            get { return data.billed_amt; }
            set { data.billed_amt = value; }
        }

        public double landed_cost_voucher_amount
        {
            get { return data.landed_cost_voucher_amount; }
            set { data.landed_cost_voucher_amount = value; }
        }

        public string brand
        {
            get { return data.brand; }
            set { data.brand = value; }
        }

        public string item_group
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        public double rm_supp_cost
        {
            get { return data.rm_supp_cost; }
            set { data.rm_supp_cost = value; }
        }

        public double item_tax_amount
        {
            get { return data.item_tax_amount; }
            set { data.item_tax_amount = value; }
        }

        public double valuation_rate
        {
            get { return data.valuation_rate; }
            set { data.valuation_rate = value; }
        }

        public string item_tax_rate
        {
            get { return data.item_tax_rate; }
            set { data.item_tax_rate = value; }
        }

        public long page_break
        {
            get { return data.page_break; }
            set { data.page_break = value; }
        }

        public string material_request
        {
            get { return data.material_request; }
            set { data.material_request = value; }
        }

        public string material_request_item
        {
            get { return data.material_request_item; }
            set { data.material_request_item = value; }
        }

        public string expense_account
        {
            get { return data.expense_account; }
            set { data.expense_account = value; }
        }

        public string manufacturer
        {
            get { return data.manufacturer; }
            set { data.manufacturer = value; }
        }

        public string manufacturer_part_no
        {
            get { return data.manufacturer_part_no; }
            set { data.manufacturer_part_no = value; }
        }

        public string asset_location
        {
            get { return data.asset_location; }
            set { data.asset_location = value; }
        }

        public string asset_category
        {
            get { return data.asset_category; }
            set { data.asset_category = value; }
        }

        public string from_warehouse
        {
            get { return data.from_warehouse; }
            set { data.from_warehouse = value; }
        }

        public string purchase_receipt_item
        {
            get { return data.purchase_receipt_item; }
            set { data.purchase_receipt_item = value; }
        }


    }

    //Enums go here

}