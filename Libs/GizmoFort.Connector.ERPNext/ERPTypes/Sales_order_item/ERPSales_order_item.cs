using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_order_item
{
    public class ERPSales_order_item : ERPNextObjectBase
    {
        public ERPSales_order_item() : this(new ERPObject(DocType.Sales_order_item)) { }
        public ERPSales_order_item(ERPObject obj) : base(obj) { }

        public static ERPSales_order_item Create(string itemcode, string itemname, string description, double qty, string uom, double conversionfactor)

        {
            ERPSales_order_item obj = new ERPSales_order_item();
            obj.item_code = itemcode;
            obj.item_name = itemname;
            obj.description = description;
            obj.qty = qty;
            obj.uom = uom;
            obj.conversion_factor = conversionfactor;
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

        public string customer_item_code
        {
            get { return data.customer_item_code; }
            set { data.customer_item_code = value; }
        }

        public long ensure_delivery_based_on_produced_serial_no
        {
            get { return data.ensure_delivery_based_on_produced_serial_no; }
            set { data.ensure_delivery_based_on_produced_serial_no = value; }
        }

        public string delivery_date
        {
            get { return data.delivery_date; }
            set { data.delivery_date = value; }
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

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
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

        public string prevdoc_docname
        {
            get { return data.prevdoc_docname; }
            set { data.prevdoc_docname = value; }
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

        public double billed_amt
        {
            get { return data.billed_amt; }
            set { data.billed_amt = value; }
        }

        public double valuation_rate
        {
            get { return data.valuation_rate; }
            set { data.valuation_rate = value; }
        }

        public double gross_profit
        {
            get { return data.gross_profit; }
            set { data.gross_profit = value; }
        }

        public string blanket_order
        {
            get { return data.blanket_order; }
            set { data.blanket_order = value; }
        }

        public double blanket_order_rate
        {
            get { return data.blanket_order_rate; }
            set { data.blanket_order_rate = value; }
        }

        public double projected_qty
        {
            get { return data.projected_qty; }
            set { data.projected_qty = value; }
        }

        public double actual_qty
        {
            get { return data.actual_qty; }
            set { data.actual_qty = value; }
        }

        public double ordered_qty
        {
            get { return data.ordered_qty; }
            set { data.ordered_qty = value; }
        }

        public double delivered_qty
        {
            get { return data.delivered_qty; }
            set { data.delivered_qty = value; }
        }

        public double work_order_qty
        {
            get { return data.work_order_qty; }
            set { data.work_order_qty = value; }
        }

        public double returned_qty
        {
            get { return data.returned_qty; }
            set { data.returned_qty = value; }
        }

        public string item_tax_template
        {
            get { return data.item_tax_template; }
            set { data.item_tax_template = value; }
        }

        public long page_break
        {
            get { return data.page_break; }
            set { data.page_break = value; }
        }

        public double planned_qty
        {
            get { return data.planned_qty; }
            set { data.planned_qty = value; }
        }

        public double produced_qty
        {
            get { return data.produced_qty; }
            set { data.produced_qty = value; }
        }

        public string item_tax_rate
        {
            get { return data.item_tax_rate; }
            set { data.item_tax_rate = value; }
        }

        public string transaction_date
        {
            get { return data.transaction_date; }
            set { data.transaction_date = value; }
        }

        public string additional_notes
        {
            get { return data.additional_notes; }
            set { data.additional_notes = value; }
        }

        public long against_blanket_order
        {
            get { return data.against_blanket_order; }
            set { data.against_blanket_order = value; }
        }

        public string bom_no
        {
            get { return data.bom_no; }
            set { data.bom_no = value; }
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