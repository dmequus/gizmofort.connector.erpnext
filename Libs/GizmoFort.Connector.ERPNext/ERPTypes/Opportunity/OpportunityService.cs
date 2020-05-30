using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Opportunity
{
    public class OpportunityService : SubServiceBase<ERPOpportunity>
    {
        public OpportunityService(ERPNextClient client)
            : base(DocType.Opportunity, client) { }

        protected override ERPOpportunity fromERPObject(ERPObject obj)
        {
            return new ERPOpportunity(obj);
        }
    }
}