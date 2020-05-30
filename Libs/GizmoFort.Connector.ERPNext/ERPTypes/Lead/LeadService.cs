using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Lead
{
    public class LeadService : SubServiceBase<ERPLead>
    {
        public LeadService(ERPNextClient client)
            : base(DocType.Lead, client) { }

        protected override ERPLead fromERPObject(ERPObject obj)
        {
            return new ERPLead(obj);
        }
    }
}