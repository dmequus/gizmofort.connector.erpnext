using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Product_bundle_item
{
    public class ERPProduct_bundle_item : ERPNextObjectBase
    {
        public ERPProduct_bundle_item() : this(new ERPObject(DocType.Product_bundle_item)) { }
        public ERPProduct_bundle_item(ERPObject obj) : base(obj) { }

        public static ERPProduct_bundle_item Create(string itemcode, double qty)

        {
            ERPProduct_bundle_item obj = new ERPProduct_bundle_item();
            obj.item_code = itemcode;
            obj.qty = qty;
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

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        private double _rate = 0.0;
        public double rate
        {
            get { return data._rate; }
            set { data._rate = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }


    }

    //Enums go here

}