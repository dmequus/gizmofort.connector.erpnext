using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_quotation_item
{
    public class ERPSupplier_quotation_item : ERPNextObjectBase
    {
        public ERPSupplier_quotation_item() : this(new ERPObject(DocType.Supplier_quotation_item)) { }
        public ERPSupplier_quotation_item(ERPObject obj) : base(obj) { }

        public static ERPSupplier_quotation_item Create(string itemcode, string description, double qty, string stockuom, string uom, double conversionfactor, double baserate, double baseamount)

        {
            ERPSupplier_quotation_item obj = new ERPSupplier_quotation_item();
            obj.item_code = itemcode;
            obj.description = description;
            obj.qty = qty;
            obj.stock_uom = stockuom;
            obj.uom = uom;
            obj.conversion_factor = conversionfactor;
            obj.base_rate = baserate;
            obj.base_amount = baseamount;
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

        public double base_amount
        {
            get { return data.base_amount; }
            set { data.base_amount = value; }
        }

        public string supplier_part_no
        {
            get { return data.supplier_part_no; }
            set { data.supplier_part_no = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public int lead_time_days
        {
            get { return data.lead_time_days; }
            set { data.lead_time_days = value; }
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

        public double stock_qty
        {
            get { return data.stock_qty; }
            set { data.stock_qty = value; }
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

        public string project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        public string prevdoc_doctype
        {
            get { return data.prevdoc_doctype; }
            set { data.prevdoc_doctype = value; }
        }

        public string material_request
        {
            get { return data.material_request; }
            set { data.material_request = value; }
        }

        public string sales_order
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        public string request_for_quotation
        {
            get { return data.request_for_quotation; }
            set { data.request_for_quotation = value; }
        }

        public string item_tax_template
        {
            get { return data.item_tax_template; }
            set { data.item_tax_template = value; }
        }

        public string material_request_item
        {
            get { return data.material_request_item; }
            set { data.material_request_item = value; }
        }

        public string request_for_quotation_item
        {
            get { return data.request_for_quotation_item; }
            set { data.request_for_quotation_item = value; }
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

        public long page_break
        {
            get { return data.page_break; }
            set { data.page_break = value; }
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


    }

    //Enums go here

}