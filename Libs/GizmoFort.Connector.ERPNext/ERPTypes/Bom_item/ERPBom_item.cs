using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom_item
{
    public class ERPBom_item : ERPNextObjectBase
    {
        public ERPBom_item() : this(new ERPObject(DocType.Bom_item)) { }
        public ERPBom_item(ERPObject obj) : base(obj) { }

        public static ERPBom_item Create(string itemcode, double qty, string uom, double rate)

        {
            ERPBom_item obj = new ERPBom_item();
            obj.item_code = itemcode;
            obj.qty = qty;
            obj.uom = uom;
            obj.rate = rate;
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

        public double rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string operation
        {
            get { return data.operation; }
            set { data.operation = value; }
        }

        public string bom_no
        {
            get { return data.bom_no; }
            set { data.bom_no = value; }
        }

        public string source_warehouse
        {
            get { return data.source_warehouse; }
            set { data.source_warehouse = value; }
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

        public double stock_qty
        {
            get { return data.stock_qty; }
            set { data.stock_qty = value; }
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

        public double scrap
        {
            get { return data.scrap; }
            set { data.scrap = value; }
        }

        public double qty_consumed_per_unit
        {
            get { return data.qty_consumed_per_unit; }
            set { data.qty_consumed_per_unit = value; }
        }

        public long allow_alternative_item
        {
            get { return data.allow_alternative_item; }
            set { data.allow_alternative_item = value; }
        }

        public long include_item_in_manufacturing
        {
            get { return data.include_item_in_manufacturing; }
            set { data.include_item_in_manufacturing = value; }
        }

        public string original_item
        {
            get { return data.original_item; }
            set { data.original_item = value; }
        }

        public long has_variants
        {
            get { return data.has_variants; }
            set { data.has_variants = value; }
        }


    }

    //Enums go here

}