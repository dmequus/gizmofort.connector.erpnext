using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Opportunity_item
{
    public class Opportunity_itemService : SubServiceBase<ERPOpportunity_item>
    {
        public Opportunity_itemService(ERPNextClient client)
            : base(DocType.Opportunity_item, client) { }

        protected override ERPOpportunity_item fromERPObject(ERPObject obj)
        {
            return new ERPOpportunity_item(obj);
        }
    }
}