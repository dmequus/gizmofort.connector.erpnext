using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_price
{
    public class ERPItem_price : ERPNextObjectBase
    {
        public ERPItem_price() : this(new ERPObject(DocType.Item_price)) { }
        public ERPItem_price(ERPObject obj) : base(obj) { }

        public static ERPItem_price Create(string itemname, string itemcode, string pricelist, double pricelistrate)

        {
            ERPItem_price obj = new ERPItem_price();
            obj.item_name = itemname;
            obj.item_code = itemcode;
            obj.price_list = pricelist;
            obj.price_list_rate = pricelistrate;
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

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string price_list
        {
            get { return data.price_list; }
            set { data.price_list = value; }
        }

        public double price_list_rate
        {
            get { return data.price_list_rate; }
            set { data.price_list_rate = value; }
        }

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        public int packing_unit
        {
            get { return data.packing_unit; }
            set { data.packing_unit = value; }
        }

        public string brand
        {
            get { return data.brand; }
            set { data.brand = value; }
        }

        public string item_description
        {
            get { return data.item_description; }
            set { data.item_description = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        public long buying
        {
            get { return data.buying; }
            set { data.buying = value; }
        }

        public long selling
        {
            get { return data.selling; }
            set { data.selling = value; }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        public string valid_from
        {
            get { return data.valid_from; }
            set { data.valid_from = value; }
        }

        public int lead_time_days
        {
            get { return data.lead_time_days; }
            set { data.lead_time_days = value; }
        }

        public string valid_upto
        {
            get { return data.valid_upto; }
            set { data.valid_upto = value; }
        }

        public string note
        {
            get { return data.note; }
            set { data.note = value; }
        }

        public string reference
        {
            get { return data.reference; }
            set { data.reference = value; }
        }


    }

    //Enums go here

}