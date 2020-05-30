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

        private double _received_qty = 0.0;
        public double received_qty
        {
            get { return data._received_qty; }
            set { data._received_qty = value; }
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

        private double _conversion_factor = 0.0;
        public double conversion_factor
        {
            get { return data._conversion_factor; }
            set { data._conversion_factor = value; }
        }

        private double _base_rate = 0.0;
        public double base_rate
        {
            get { return data._base_rate; }
            set { data._base_rate = value; }
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

        private double _qty = 0.0;
        public double qty
        {
            get { return data._qty; }
            set { data._qty = value; }
        }

        private double _rejected_qty = 0.0;
        public double rejected_qty
        {
            get { return data._rejected_qty; }
            set { data._rejected_qty = value; }
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

        private double _price_list_rate = 0.0;
        public double price_list_rate
        {
            get { return data._price_list_rate; }
            set { data._price_list_rate = value; }
        }

        private double _discount_percentage = 0.0;
        public double discount_percentage
        {
            get { return data._discount_percentage; }
            set { data._discount_percentage = value; }
        }

        private double _discount_amount = 0.0;
        public double discount_amount
        {
            get { return data._discount_amount; }
            set { data._discount_amount = value; }
        }

        private double _base_price_list_rate = 0.0;
        public double base_price_list_rate
        {
            get { return data._base_price_list_rate; }
            set { data._base_price_list_rate = value; }
        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        private double _base_amount = 0.0;
        public double base_amount
        {
            get { return data._base_amount; }
            set { data._base_amount = value; }
        }

        public string pricing_rules
        {
            get { return data.pricing_rules; }
            set { data.pricing_rules = value; }
        }

        private int _is_free_item = 0;
        public int is_free_item
        {
            get { return data._is_free_item; }
            set { data._is_free_item = value; }
        }

        private double _net_rate = 0.0;
        public double net_rate
        {
            get { return data._net_rate; }
            set { data._net_rate = value; }
        }

        private double _net_amount = 0.0;
        public double net_amount
        {
            get { return data._net_amount; }
            set { data._net_amount = value; }
        }

        private double _base_net_rate = 0.0;
        public double base_net_rate
        {
            get { return data._base_net_rate; }
            set { data._base_net_rate = value; }
        }

        private double _base_net_amount = 0.0;
        public double base_net_amount
        {
            get { return data._base_net_amount; }
            set { data._base_net_amount = value; }
        }

        private double _weight_per_unit = 0.0;
        public double weight_per_unit
        {
            get { return data._weight_per_unit; }
            set { data._weight_per_unit = value; }
        }

        private double _total_weight = 0.0;
        public double total_weight
        {
            get { return data._total_weight; }
            set { data._total_weight = value; }
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

        private int _is_fixed_asset = 0;
        public int is_fixed_asset
        {
            get { return data._is_fixed_asset; }
            set { data._is_fixed_asset = value; }
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

        private double _stock_qty = 0.0;
        public double stock_qty
        {
            get { return data._stock_qty; }
            set { data._stock_qty = value; }
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

        private int _allow_zero_valuation_rate = 0;
        public int allow_zero_valuation_rate
        {
            get { return data._allow_zero_valuation_rate; }
            set { data._allow_zero_valuation_rate = value; }
        }

        public string bom
        {
            get { return data.bom; }
            set { data.bom = value; }
        }

        private int _include_exploded_items = 0;
        public int include_exploded_items
        {
            get { return data._include_exploded_items; }
            set { data._include_exploded_items = value; }
        }

        private double _billed_amt = 0.0;
        public double billed_amt
        {
            get { return data._billed_amt; }
            set { data._billed_amt = value; }
        }

        private double _landed_cost_voucher_amount = 0.0;
        public double landed_cost_voucher_amount
        {
            get { return data._landed_cost_voucher_amount; }
            set { data._landed_cost_voucher_amount = value; }
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

        private double _rm_supp_cost = 0.0;
        public double rm_supp_cost
        {
            get { return data._rm_supp_cost; }
            set { data._rm_supp_cost = value; }
        }

        private double _item_tax_amount = 0.0;
        public double item_tax_amount
        {
            get { return data._item_tax_amount; }
            set { data._item_tax_amount = value; }
        }

        private double _valuation_rate = 0.0;
        public double valuation_rate
        {
            get { return data._valuation_rate; }
            set { data._valuation_rate = value; }
        }

        public string item_tax_rate
        {
            get { return data.item_tax_rate; }
            set { data.item_tax_rate = value; }
        }

        private int _page_break = 0;
        public int page_break
        {
            get { return data._page_break; }
            set { data._page_break = value; }
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