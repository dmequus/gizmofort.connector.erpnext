using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Routing
{
    public class RoutingService : SubServiceBase<ERPRouting>
    {
        public RoutingService(ERPNextClient client)
            : base(DocType.Routing, client) { }

        protected override ERPRouting fromERPObject(ERPObject obj)
        {
            return new ERPRouting(obj);
        }
    }
}