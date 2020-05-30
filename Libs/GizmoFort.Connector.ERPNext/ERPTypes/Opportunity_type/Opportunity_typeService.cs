using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Opportunity_type
{
    public class Opportunity_typeService : SubServiceBase<ERPOpportunity_type>
    {
        public Opportunity_typeService(ERPNextClient client)
            : base(DocType.Opportunity_type, client) { }

        protected override ERPOpportunity_type fromERPObject(ERPObject obj)
        {
            return new ERPOpportunity_type(obj);
        }
    }
}