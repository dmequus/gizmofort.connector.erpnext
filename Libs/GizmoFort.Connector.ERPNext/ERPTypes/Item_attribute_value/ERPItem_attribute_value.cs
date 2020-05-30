using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_attribute_value
{
    public class ERPItem_attribute_value : ERPNextObjectBase
    {
        public ERPItem_attribute_value() : this(new ERPObject(DocType.Item_attribute_value)) { }
        public ERPItem_attribute_value(ERPObject obj) : base(obj) { }

        public static ERPItem_attribute_value Create(string attributevalue, string abbr)

        {
            ERPItem_attribute_value obj = new ERPItem_attribute_value();
            obj.attribute_value = attributevalue;
            obj.abbr = abbr;
            return obj;
        }

        public string attribute_value
        {
            get { return data.attribute_value; }
            set
            {
                data.attribute_value = value;
                data.name = value;
            }

        }

        public string abbr
        {
            get { return data.abbr; }
            set { data.abbr = value; }
        }


    }

    //Enums go here

}