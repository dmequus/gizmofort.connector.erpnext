using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom_explosion_item
{
    public class ERPBom_explosion_item : ERPNextObjectBase
    {
        public ERPBom_explosion_item() : this(new ERPObject(DocType.Bom_explosion_item)) { }
        public ERPBom_explosion_item(ERPObject obj) : base(obj) { }

        public static ERPBom_explosion_item Create(string itemcode, string itemname, string sourcewarehouse, string operation, string description, string image, string imageview, double stockqty, double rate, double qtyconsumedperunit, string stockuom, double amount, int includeiteminmanufacturing)

        {
            ERPBom_explosion_item obj = new ERPBom_explosion_item();
            obj.item_code = itemcode;
            obj.item_name = itemname;
            obj.source_warehouse = sourcewarehouse;
            obj.operation = operation;
            obj.description = description;
            obj.image = image;
            obj.image_view = imageview;
            obj.stock_qty = stockqty;
            obj.rate = rate;
            obj.qty_consumed_per_unit = qtyconsumedperunit;
            obj.stock_uom = stockuom;
            obj.amount = amount;
            obj.include_item_in_manufacturing = includeiteminmanufacturing;
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

        public string source_warehouse
        {
            get { return data.source_warehouse; }
            set { data.source_warehouse = value; }
        }

        public string operation
        {
            get { return data.operation; }
            set { data.operation = value; }
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

        private double _stock_qty = 0.0;
        public double stock_qty
        {
            get { return data._stock_qty; }
            set { data._stock_qty = value; }
        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
        }

        private double _qty_consumed_per_unit = 0.0;
        public double qty_consumed_per_unit
        {
            get { return data._qty_consumed_per_unit; }
            set { data._qty_consumed_per_unit = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        private int _include_item_in_manufacturing = 0;
        public int include_item_in_manufacturing
        {
            get { return data._include_item_in_manufacturing; }
            set { data._include_item_in_manufacturing = value; }
        }


    }

    //Enums go here

}