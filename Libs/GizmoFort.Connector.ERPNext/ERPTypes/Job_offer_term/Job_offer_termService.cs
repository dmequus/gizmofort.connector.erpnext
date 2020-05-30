using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_offer_term
{
    public class Job_offer_termService : SubServiceBase<ERPJob_offer_term>
    {
        public Job_offer_termService(ERPNextClient client)
            : base(DocType.Job_offer_term, client) { }

        protected override ERPJob_offer_term fromERPObject(ERPObject obj)
        {
            return new ERPJob_offer_term(obj);
        }
    }
}