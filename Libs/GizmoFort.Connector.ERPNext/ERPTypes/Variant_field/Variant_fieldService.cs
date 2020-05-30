using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Variant_field
{
    public class Variant_fieldService : SubServiceBase<ERPVariant_field>
    {
        public Variant_fieldService(ERPNextClient client)
            : base(DocType.Variant_field, client) { }

        protected override ERPVariant_field fromERPObject(ERPObject obj)
        {
            return new ERPVariant_field(obj);
        }
    }
}