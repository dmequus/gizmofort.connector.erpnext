using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_variant
{
    public class ERPItem_variant : ERPNextObjectBase
    {
        public ERPItem_variant() : this(new ERPObject(DocType.Item_variant)) { }
        public ERPItem_variant(ERPObject obj) : base(obj) { }

        public static ERPItem_variant Create(string itemattribute, string itemattributevalue)

        {
            ERPItem_variant obj = new ERPItem_variant();
            obj.item_attribute = itemattribute;
            obj.item_attribute_value = itemattributevalue;
            return obj;
        }

        public string item_attribute
        {
            get { return data.item_attribute; }
            set
            {
                data.item_attribute = value;
                data.name = value;
            }

        }

        public string item_attribute_value
        {
            get { return data.item_attribute_value; }
            set { data.item_attribute_value = value; }
        }


    }

    //Enums go here

}