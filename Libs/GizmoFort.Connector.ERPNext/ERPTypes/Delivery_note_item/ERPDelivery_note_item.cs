using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Delivery_note_item
{
    public class ERPDelivery_note_item : ERPNextObjectBase
    {
        public ERPDelivery_note_item() : this(new ERPObject(DocType.Delivery_note_item)) { }
        public ERPDelivery_note_item(ERPObject obj) : base(obj) { }

        public static ERPDelivery_note_item Create(string itemcode, string itemname, string description, double qty, string stockuom, string uom, double conversionfactor)

        {
            ERPDelivery_note_item obj = new ERPDelivery_note_item();
            obj.item_code = itemcode;
            obj.item_name = itemname;
            obj.description = description;
            obj.qty = qty;
            obj.stock_uom = stockuom;
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

        private double _qty = 0.0;
        public double qty
        {
            get { return data._qty; }
            set { data._qty = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        private double _conversion_factor = 0.0;
        public double conversion_factor
        {
            get { return data._conversion_factor; }
            set { data._conversion_factor = value; }
        }

        public string barcode
        {
            get { return data.barcode; }
            set { data.barcode = value; }
        }

        public string customer_item_code
        {
            get { return data.customer_item_code; }
            set { data.customer_item_code = value; }
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

        private double _stock_qty = 0.0;
        public double stock_qty
        {
            get { return data._stock_qty; }
            set { data._stock_qty = value; }
        }

        private double _price_list_rate = 0.0;
        public double price_list_rate
        {
            get { return data._price_list_rate; }
            set { data._price_list_rate = value; }
        }

        private double _base_price_list_rate = 0.0;
        public double base_price_list_rate
        {
            get { return data._base_price_list_rate; }
            set { data._base_price_list_rate = value; }
        }

        public Margintype margin_type
        {
            get { return parseEnum<Margintype>(data.margin_type); }
            set { data.margin_type = value.ToString(); }
        }

        private double _margin_rate_or_amount = 0.0;
        public double margin_rate_or_amount
        {
            get { return data._margin_rate_or_amount; }
            set { data._margin_rate_or_amount = value; }
        }

        private double _rate_with_margin = 0.0;
        public double rate_with_margin
        {
            get { return data._rate_with_margin; }
            set { data._rate_with_margin = value; }
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

        private double _base_rate_with_margin = 0.0;
        public double base_rate_with_margin
        {
            get { return data._base_rate_with_margin; }
            set { data._base_rate_with_margin = value; }
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

        private double _base_rate = 0.0;
        public double base_rate
        {
            get { return data._base_rate; }
            set { data._base_rate = value; }
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

        private double _actual_qty = 0.0;
        public double actual_qty
        {
            get { return data._actual_qty; }
            set { data._actual_qty = value; }
        }

        private double _actual_batch_qty = 0.0;
        public double actual_batch_qty
        {
            get { return data._actual_batch_qty; }
            set { data._actual_batch_qty = value; }
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

        public string cost_center
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        private int _allow_zero_valuation_rate = 0;
        public int allow_zero_valuation_rate
        {
            get { return data._allow_zero_valuation_rate; }
            set { data._allow_zero_valuation_rate = value; }
        }

        public string against_sales_order
        {
            get { return data.against_sales_order; }
            set { data.against_sales_order = value; }
        }

        public string against_sales_invoice
        {
            get { return data.against_sales_invoice; }
            set { data.against_sales_invoice = value; }
        }

        public string so_detail
        {
            get { return data.so_detail; }
            set { data.so_detail = value; }
        }

        public string si_detail
        {
            get { return data.si_detail; }
            set { data.si_detail = value; }
        }

        private double _installed_qty = 0.0;
        public double installed_qty
        {
            get { return data._installed_qty; }
            set { data._installed_qty = value; }
        }

        private double _billed_amt = 0.0;
        public double billed_amt
        {
            get { return data._billed_amt; }
            set { data._billed_amt = value; }
        }

        private int _page_break = 0;
        public int page_break
        {
            get { return data._page_break; }
            set { data._page_break = value; }
        }

        public string dn_detail
        {
            get { return data.dn_detail; }
            set { data.dn_detail = value; }
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