using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_variant_attribute
{
    public class ERPItem_variant_attribute : ERPNextObjectBase
    {
        public ERPItem_variant_attribute() : this(new ERPObject(DocType.Item_variant_attribute)) { }
        public ERPItem_variant_attribute(ERPObject obj) : base(obj) { }

        public static ERPItem_variant_attribute Create(string variantof, string attribute, string attributevalue, int numericvalues, double fromrange, double increment, double torange)

        {
            ERPItem_variant_attribute obj = new ERPItem_variant_attribute();
            obj.variant_of = variantof;
            obj.attribute = attribute;
            obj.attribute_value = attributevalue;
            obj.numeric_values = numericvalues;
            obj.from_range = fromrange;
            obj.increment = increment;
            obj.to_range = torange;
            return obj;
        }

        public string variant_of
        {
            get { return data.variant_of; }
            set
            {
                data.variant_of = value;
                data.name = value;
            }

        }

        public string attribute
        {
            get { return data.attribute; }
            set { data.attribute = value; }
        }

        public string attribute_value
        {
            get { return data.attribute_value; }
            set { data.attribute_value = value; }
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


    }

    //Enums go here

}