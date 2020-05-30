using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Offer_term
{
    public class Offer_termService : SubServiceBase<ERPOffer_term>
    {
        public Offer_termService(ERPNextClient client)
            : base(DocType.Offer_term, client) { }

        protected override ERPOffer_term fromERPObject(ERPObject obj)
        {
            return new ERPOffer_term(obj);
        }
    }
}