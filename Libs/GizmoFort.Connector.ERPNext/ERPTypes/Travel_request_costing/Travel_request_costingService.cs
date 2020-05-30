using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Travel_request_costing
{
    public class Travel_request_costingService : SubServiceBase<ERPTravel_request_costing>
    {
        public Travel_request_costingService(ERPNextClient client)
            : base(DocType.Travel_request_costing, client) { }

        protected override ERPTravel_request_costing fromERPObject(ERPObject obj)
        {
            return new ERPTravel_request_costing(obj);
        }
    }
}