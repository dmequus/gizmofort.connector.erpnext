using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Promotional_scheme
{
    public class Promotional_schemeService : SubServiceBase<ERPPromotional_scheme>
    {
        public Promotional_schemeService(ERPNextClient client)
            : base(DocType.Promotional_scheme, client) { }

        protected override ERPPromotional_scheme fromERPObject(ERPObject obj)
        {
            return new ERPPromotional_scheme(obj);
        }
    }
}