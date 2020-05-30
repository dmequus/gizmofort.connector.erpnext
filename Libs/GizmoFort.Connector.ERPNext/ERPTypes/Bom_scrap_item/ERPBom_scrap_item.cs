using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom_scrap_item
{
    public class ERPBom_scrap_item : ERPNextObjectBase
    {
        public ERPBom_scrap_item() : this(new ERPObject(DocType.Bom_scrap_item)) { }
        public ERPBom_scrap_item(ERPObject obj) : base(obj) { }

        public static ERPBom_scrap_item Create(string itemcode, string itemname, double stockqty, double rate, double amount, string stockuom, double baserate, double baseamount)

        {
            ERPBom_scrap_item obj = new ERPBom_scrap_item();
            obj.item_code = itemcode;
            obj.item_name = itemname;
            obj.stock_qty = stockqty;
            obj.rate = rate;
            obj.amount = amount;
            obj.stock_uom = stockuom;
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

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
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

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        public string stock_uom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
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


    }

    //Enums go here

}