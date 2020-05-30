using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Opportunity_lost_reason
{
    public class Opportunity_lost_reasonService : SubServiceBase<ERPOpportunity_lost_reason>
    {
        public Opportunity_lost_reasonService(ERPNextClient client)
            : base(DocType.Opportunity_lost_reason, client) { }

        protected override ERPOpportunity_lost_reason fromERPObject(ERPObject obj)
        {
            return new ERPOpportunity_lost_reason(obj);
        }
    }
}