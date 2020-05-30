using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom_website_item
{
    public class ERPBom_website_item : ERPNextObjectBase
    {
        public ERPBom_website_item() : this(new ERPObject(DocType.Bom_website_item)) { }
        public ERPBom_website_item(ERPObject obj) : base(obj) { }

        public static ERPBom_website_item Create(string itemcode, string itemname, string description, double qty, string websiteimage)

        {
            ERPBom_website_item obj = new ERPBom_website_item();
            obj.item_code = itemcode;
            obj.item_name = itemname;
            obj.description = description;
            obj.qty = qty;
            obj.website_image = websiteimage;
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

        public string website_image
        {
            get { return data.website_image; }
            set { data.website_image = value; }
        }


    }

    //Enums go here

}