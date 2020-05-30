using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Proposed_pledge
{
    public class Proposed_pledgeService : SubServiceBase<ERPProposed_pledge>
    {
        public Proposed_pledgeService(ERPNextClient client)
            : base(DocType.Proposed_pledge, client) { }

        protected override ERPProposed_pledge fromERPObject(ERPObject obj)
        {
            return new ERPProposed_pledge(obj);
        }
    }
}