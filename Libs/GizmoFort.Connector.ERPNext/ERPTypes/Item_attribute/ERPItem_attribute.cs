using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_attribute
{
    public class ERPItem_attribute : ERPNextObjectBase
    {
        public ERPItem_attribute() : this(new ERPObject(DocType.Item_attribute)) { }
        public ERPItem_attribute(ERPObject obj) : base(obj) { }

        public static ERPItem_attribute Create(string attributename, long numericvalues, double fromrange, double increment, double torange, string itemattributevalues)

        {
            ERPItem_attribute obj = new ERPItem_attribute();
            obj.attribute_name = attributename;
            obj.numeric_values = numericvalues;
            obj.from_range = fromrange;
            obj.increment = increment;
            obj.to_range = torange;
            obj.item_attribute_values = itemattributevalues;
            return obj;
        }

        public string attribute_name
        {
            get { return data.attribute_name; }
            set
            {
                data.attribute_name = value;
                data.name = value;
            }

        }

        public long numeric_values
        {
            get { return data.numeric_values; }
            set { data.numeric_values = value; }
        }

        public double from_range
        {
            get { return data.from_range; }
            set { data.from_range = value; }
        }

        public double increment
        {
            get { return data.increment; }
            set { data.increment = value; }
        }

        public double to_range
        {
            get { return data.to_range; }
            set { data.to_range = value; }
        }

        public string item_attribute_values
        {
            get { return data.item_attribute_values; }
            set { data.item_attribute_values = value; }
        }


    }

    //Enums go here

}