using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_attribute
{
    public class ERPItem_attribute : ERPNextObjectBase
    {
        public ERPItem_attribute() : this(new ERPObject(DocType.Item_attribute)) { }
        public ERPItem_attribute(ERPObject obj) : base(obj) { }

        public static ERPItem_attribute Create(string attributename, int numericvalues, double fromrange, double increment, double torange, string itemattributevalues)

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

        private int _numeric_values = 0;
        public int numeric_values
        {
            get { return data._numeric_values; }
            set { data._numeric_values = value; }
        }

        private double _from_range = 0.0;
        public double from_range
        {
            get { return data._from_range; }
            set { data._from_range = value; }
        }

        private double _increment = 0.0;
        public double increment
        {
            get { return data._increment; }
            set { data._increment = value; }
        }

        private double _to_range = 0.0;
        public double to_range
        {
            get { return data._to_range; }
            set { data._to_range = value; }
        }

        public string item_attribute_values
        {
            get { return data.item_attribute_values; }
            set { data.item_attribute_values = value; }
        }


    }

    //Enums go here

}