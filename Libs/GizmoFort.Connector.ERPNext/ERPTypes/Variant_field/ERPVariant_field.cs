using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Variant_field
{
    public class ERPVariant_field : ERPNextObjectBase
    {
        public ERPVariant_field() : this(new ERPObject(DocType.Variant_field)) { }
        public ERPVariant_field(ERPObject obj) : base(obj) { }

        public static ERPVariant_field Create(string fieldname)

        {
            ERPVariant_field obj = new ERPVariant_field();
            obj.field_name = fieldname;
            return obj;
        }

        public string field_name
        {
            get { return data.field_name; }
            set
            {
                data.field_name = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}