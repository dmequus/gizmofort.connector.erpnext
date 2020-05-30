using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Opportunity_item
{
    public class ERPOpportunity_item : ERPNextObjectBase
    {
        public ERPOpportunity_item() : this(new ERPObject(DocType.Opportunity_item)) { }
        public ERPOpportunity_item(ERPObject obj) : base(obj) { }

        public static ERPOpportunity_item Create(string itemcode, double qty, string itemgroup, string brand, string uom, string itemname, string description, string image, string imageview, double basicrate)

        {
            ERPOpportunity_item obj = new ERPOpportunity_item();
            obj.item_code = itemcode;
            obj.qty = qty;
            obj.item_group = itemgroup;
            obj.brand = brand;
            obj.uom = uom;
            obj.item_name = itemname;
            obj.description = description;
            obj.image = image;
            obj.image_view = imageview;
            obj.basic_rate = basicrate;
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

        public string uom
        {
            get { return data.uom; }
            set { data.uom = value; }
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

        private double _basic_rate = 0.0;
        public double basic_rate
        {
            get { return data._basic_rate; }
            set { data._basic_rate = value; }
        }


    }

    //Enums go here

}