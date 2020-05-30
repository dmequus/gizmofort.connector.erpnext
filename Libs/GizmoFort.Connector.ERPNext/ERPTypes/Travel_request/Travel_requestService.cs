using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Travel_request
{
    public class Travel_requestService : SubServiceBase<ERPTravel_request>
    {
        public Travel_requestService(ERPNextClient client)
            : base(DocType.Travel_request, client) { }

        protected override ERPTravel_request fromERPObject(ERPObject obj)
        {
            return new ERPTravel_request(obj);
        }
    }
}