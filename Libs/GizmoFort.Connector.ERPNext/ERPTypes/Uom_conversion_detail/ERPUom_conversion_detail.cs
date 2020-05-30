using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Uom_conversion_detail
{
    public class ERPUom_conversion_detail : ERPNextObjectBase
    {
        public ERPUom_conversion_detail() : this(new ERPObject(DocType.Uom_conversion_detail)) { }
        public ERPUom_conversion_detail(ERPObject obj) : base(obj) { }

        public static ERPUom_conversion_detail Create(string uom, double conversionfactor)

        {
            ERPUom_conversion_detail obj = new ERPUom_conversion_detail();
            obj.uom = uom;
            obj.conversion_factor = conversionfactor;
            return obj;
        }

        public string uom
        {
            get { return data.uom; }
            set
            {
                data.uom = value;
                data.name = value;
            }

        }

        public double conversion_factor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
        }


    }

    //Enums go here

}