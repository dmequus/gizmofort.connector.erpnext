using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_invoice_item
{
    public class ERPPurchase_invoice_item : ERPNextObjectBase
    {
        public ERPPurchase_invoice_item() : this(new ERPObject(DocType.Purchase_invoice_item)) { }
        public ERPPurchase_invoice_item(ERPObject obj) : base(obj) { }

        public static ERPPurchase_invoice_item Create(string itemname, double qty, string uom, double conversionfactor, double stockqty, double rate, double amount, double baserate, double baseamount)

        {
            ERPPurchase_invoice_item obj = new ERPPurchase_invoice_item();
            obj.item_name = itemname;
            obj.qty = qty;
            obj.uom = uom;
            obj.conversion_factor = conversionfactor;
            obj.stock_qty = stockqty;
            obj.rate = rate;
            obj.amount = amount;
            obj.base_rate = baserate;
            obj.base_amount = baseamount;
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

        public double qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        public double conversion_factor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
        }

        public double stock_qty
        {
            get { return data.stock_qty; }
            set { data.stock_qty = value; }
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

        public double base_rate
        {
            get { return data.base_rate; }
            set { data.base_rate = value; }
        }

        public double base_amount
        {
            get { return data.base_amount; }
            set { data.base_amount = value; }
        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
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

        public double received_qty
        {
            get { return data.received_qty; }
            set { data.received_qty = value; }
        }

        public double rejected_qty
        {
            get { return data.rejected_qty; }
            set { data.rejected_qty = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
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

        public string batch_no
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }

        public string serial_no
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        public string rejected_serial_no
        {
            get { return data.rejected_serial_no; }
            set { data.rejected_serial_no = value; }
        }

        public string expense_account
        {
            get { return data.expense_account; }
            set { data.expense_account = value; }
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

        public string deferred_expense_account
        {
            get { return data.deferred_expense_account; }
            set { data.deferred_expense_account = value; }
        }

        public string service_stop_date
        {
            get { return data.service_stop_date; }
            set { data.service_stop_date = value; }
        }

        public long enable_deferred_expense
        {
            get { return data.enable_deferred_expense; }
            set { data.enable_deferred_expense = value; }
        }

        public string service_start_date
        {
            get { return data.service_start_date; }
            set { data.service_start_date = value; }
        }

        public string service_end_date
        {
            get { return data.service_end_date; }
            set { data.service_end_date = value; }
        }

        public long allow_zero_valuation_rate
        {
            get { return data.allow_zero_valuation_rate; }
            set { data.allow_zero_valuation_rate = value; }
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

        public string item_tax_rate
        {
            get { return data.item_tax_rate; }
            set { data.item_tax_rate = value; }
        }

        public double item_tax_amount
        {
            get { return data.item_tax_amount; }
            set { data.item_tax_amount = value; }
        }

        public string purchase_order
        {
            get { return data.purchase_order; }
            set { data.purchase_order = value; }
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

        public long is_fixed_asset
        {
            get { return data.is_fixed_asset; }
            set { data.is_fixed_asset = value; }
        }

        public string asset_location
        {
            get { return data.asset_location; }
            set { data.asset_location = value; }
        }

        public string po_detail
        {
            get { return data.po_detail; }
            set { data.po_detail = value; }
        }

        public string purchase_receipt
        {
            get { return data.purchase_receipt; }
            set { data.purchase_receipt = value; }
        }

        public long page_break
        {
            get { return data.page_break; }
            set { data.page_break = value; }
        }

        public string pr_detail
        {
            get { return data.pr_detail; }
            set { data.pr_detail = value; }
        }

        public double valuation_rate
        {
            get { return data.valuation_rate; }
            set { data.valuation_rate = value; }
        }

        public double rm_supp_cost
        {
            get { return data.rm_supp_cost; }
            set { data.rm_supp_cost = value; }
        }

        public double landed_cost_voucher_amount
        {
            get { return data.landed_cost_voucher_amount; }
            set { data.landed_cost_voucher_amount = value; }
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


    }

    //Enums go here

}