using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_website_specification
{
    public class ERPItem_website_specification : ERPNextObjectBase
    {
        public ERPItem_website_specification() : this(new ERPObject(DocType.Item_website_specification)) { }
        public ERPItem_website_specification(ERPObject obj) : base(obj) { }

        public static ERPItem_website_specification Create(string label, string description)

        {
            ERPItem_website_specification obj = new ERPItem_website_specification();
            obj.label = label;
            obj.description = description;
            return obj;
        }

        public string label
        {
            get { return data.label; }
            set
            {
                data.label = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here

}