using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Uom_conversion_factor
{
    public class ERPUom_conversion_factor : ERPNextObjectBase
    {
        public ERPUom_conversion_factor() : this(new ERPObject(DocType.Uom_conversion_factor)) { }
        public ERPUom_conversion_factor(ERPObject obj) : base(obj) { }

        public static ERPUom_conversion_factor Create(string category, string fromuom, string touom, double value)

        {
            ERPUom_conversion_factor obj = new ERPUom_conversion_factor();
            obj.category = category;
            obj.from_uom = fromuom;
            obj.to_uom = touom;
            obj.value = value;
            return obj;
        }

        public string category
        {
            get { return data.category; }
            set
            {
                data.category = value;
                data.name = value;
            }

        }

        public string from_uom
        {
            get { return data.from_uom; }
            set { data.from_uom = value; }
        }

        public string to_uom
        {
            get { return data.to_uom; }
            set { data.to_uom = value; }
        }

        private double _value = 0.0;
        public double value
        {
            get { return data._value; }
            set { data._value = value; }
        }


    }

    //Enums go here

}