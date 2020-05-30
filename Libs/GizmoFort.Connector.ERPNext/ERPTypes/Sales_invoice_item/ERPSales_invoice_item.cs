using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_invoice_item
{
    public class ERPSales_invoice_item : ERPNextObjectBase
    {
        public ERPSales_invoice_item() : this(new ERPObject(DocType.Sales_invoice_item)) { }
        public ERPSales_invoice_item(ERPObject obj) : base(obj) { }

        public static ERPSales_invoice_item Create(string itemname, string description, string uom, double conversionfactor, double rate, double amount, double baserate, double baseamount, string incomeaccount, string costcenter)

        {
            ERPSales_invoice_item obj = new ERPSales_invoice_item();
            obj.item_name = itemname;
            obj.description = description;
            obj.uom = uom;
            obj.conversion_factor = conversionfactor;
            obj.rate = rate;
            obj.amount = amount;
            obj.base_rate = baserate;
            obj.base_amount = baseamount;
            obj.income_account = incomeaccount;
            obj.cost_center = costcenter;
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

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
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

        public string income_account
        {
            get { return data.income_account; }
            set { data.income_account = value; }
        }

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        public string barcode
        {
            get { return data.barcode; }
            set { data.barcode = value; }
        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string customer_item_code
        {
            get { return data.customer_item_code; }
            set { data.customer_item_code = value; }
        }

        public string image_view
        {
            get { return data.image_view; }
            set { data.image_view = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public double qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        public double stock_qty
        {
            get { return data.stock_qty; }
            set { data.stock_qty = value; }
        }

        public double price_list_rate
        {
            get { return data.price_list_rate; }
            set { data.price_list_rate = value; }
        }

        public double base_price_list_rate
        {
            get { return data.base_price_list_rate; }
            set { data.base_price_list_rate = value; }
        }

        public Margintype margin_type
        {
            get { return parseEnum<Margintype>(data.margin_type); }
            set { data.margin_type = value.ToString(); }
        }

        public double margin_rate_or_amount
        {
            get { return data.margin_rate_or_amount; }
            set { data.margin_rate_or_amount = value; }
        }

        public double rate_with_margin
        {
            get { return data.rate_with_margin; }
            set { data.rate_with_margin = value; }
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

        public double base_rate_with_margin
        {
            get { return data.base_rate_with_margin; }
            set { data.base_rate_with_margin = value; }
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

        public long delivered_by_supplier
        {
            get { return data.delivered_by_supplier; }
            set { data.delivered_by_supplier = value; }
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

        public string deferred_revenue_account
        {
            get { return data.deferred_revenue_account; }
            set { data.deferred_revenue_account = value; }
        }

        public string service_stop_date
        {
            get { return data.service_stop_date; }
            set { data.service_stop_date = value; }
        }

        public long enable_deferred_revenue
        {
            get { return data.enable_deferred_revenue; }
            set { data.enable_deferred_revenue = value; }
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

        public string target_warehouse
        {
            get { return data.target_warehouse; }
            set { data.target_warehouse = value; }
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

        public long allow_zero_valuation_rate
        {
            get { return data.allow_zero_valuation_rate; }
            set { data.allow_zero_valuation_rate = value; }
        }

        public string serial_no
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        public string item_group
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        public string brand
        {
            get { return data.brand; }
            set { data.brand = value; }
        }

        public string item_tax_rate
        {
            get { return data.item_tax_rate; }
            set { data.item_tax_rate = value; }
        }

        public double actual_batch_qty
        {
            get { return data.actual_batch_qty; }
            set { data.actual_batch_qty = value; }
        }

        public double actual_qty
        {
            get { return data.actual_qty; }
            set { data.actual_qty = value; }
        }

        public string sales_order
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        public string so_detail
        {
            get { return data.so_detail; }
            set { data.so_detail = value; }
        }

        public string delivery_note
        {
            get { return data.delivery_note; }
            set { data.delivery_note = value; }
        }

        public string dn_detail
        {
            get { return data.dn_detail; }
            set { data.dn_detail = value; }
        }

        public double delivered_qty
        {
            get { return data.delivered_qty; }
            set { data.delivered_qty = value; }
        }

        public long is_fixed_asset
        {
            get { return data.is_fixed_asset; }
            set { data.is_fixed_asset = value; }
        }

        public string asset
        {
            get { return data.asset; }
            set { data.asset = value; }
        }

        public long page_break
        {
            get { return data.page_break; }
            set { data.page_break = value; }
        }

        public string finance_book
        {
            get { return data.finance_book; }
            set { data.finance_book = value; }
        }


    }

    //Enums go here
    public enum Margintype
    {
        [Description("Percentage")]
        Percentage,
        [Description("Amount")]
        Amount,
    }


}