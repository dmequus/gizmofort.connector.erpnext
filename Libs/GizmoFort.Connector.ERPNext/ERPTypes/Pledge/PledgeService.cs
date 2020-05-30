using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pledge
{
    public class PledgeService : SubServiceBase<ERPPledge>
    {
        public PledgeService(ERPNextClient client)
            : base(DocType.Pledge, client) { }

        protected override ERPPledge fromERPObject(ERPObject obj)
        {
            return new ERPPledge(obj);
        }
    }
}