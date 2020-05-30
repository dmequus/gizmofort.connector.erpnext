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

        private double _qty = 0.0;
        public double qty
        {
            get { return data._qty; }
            set { data._qty = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
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

        private double _stock_qty = 0.0;
        public double stock_qty
        {
            get { return data._stock_qty; }
            set { data._stock_qty = value; }
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

        private double _scrap = 0.0;
        public double scrap
        {
            get { return data._scrap; }
            set { data._scrap = value; }
        }

        private double _qty_consumed_per_unit = 0.0;
        public double qty_consumed_per_unit
        {
            get { return data._qty_consumed_per_unit; }
            set { data._qty_consumed_per_unit = value; }
        }

        private int _allow_alternative_item = 0;
        public int allow_alternative_item
        {
            get { return data._allow_alternative_item; }
            set { data._allow_alternative_item = value; }
        }

        private int _include_item_in_manufacturing = 0;
        public int include_item_in_manufacturing
        {
            get { return data._include_item_in_manufacturing; }
            set { data._include_item_in_manufacturing = value; }
        }

        public string original_item
        {
            get { return data.original_item; }
            set { data.original_item = value; }
        }

        private int _has_variants = 0;
        public int has_variants
        {
            get { return data._has_variants; }
            set { data._has_variants = value; }
        }


    }

    //Enums go here

}