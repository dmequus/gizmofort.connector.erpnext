using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_variant_attribute
{
    public class ERPItem_variant_attribute : ERPNextObjectBase
    {
        public ERPItem_variant_attribute() : this(new ERPObject(DocType.Item_variant_attribute)) { }
        public ERPItem_variant_attribute(ERPObject obj) : base(obj) { }

        public static ERPItem_variant_attribute Create(string variantof, string attribute, string attributevalue, long numericvalues, double fromrange, double increment, double torange)

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


    }

    //Enums go here

}