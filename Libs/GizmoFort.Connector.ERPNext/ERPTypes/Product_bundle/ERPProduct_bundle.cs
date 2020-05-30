using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Product_bundle
{
    public class ERPProduct_bundle : ERPNextObjectBase
    {
        public ERPProduct_bundle() : this(new ERPObject(DocType.Product_bundle)) { }
        public ERPProduct_bundle(ERPObject obj) : base(obj) { }

        public static ERPProduct_bundle Create(string newitemcode, string description, string items, string about)

        {
            ERPProduct_bundle obj = new ERPProduct_bundle();
            obj.new_item_code = newitemcode;
            obj.description = description;
            obj.items = items;
            obj.about = about;
            return obj;
        }

        public string new_item_code
        {
            get { return data.new_item_code; }
            set
            {
                data.new_item_code = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        public string about
        {
            get { return data.about; }
            set { data.about = value; }
        }


    }

    //Enums go here

}