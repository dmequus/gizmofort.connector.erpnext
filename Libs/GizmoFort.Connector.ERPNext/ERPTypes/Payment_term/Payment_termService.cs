using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_term
{
    public class Payment_termService : SubServiceBase<ERPPayment_term>
    {
        public Payment_termService(ERPNextClient client)
            : base(DocType.Payment_term, client) { }

        protected override ERPPayment_term fromERPObject(ERPObject obj)
        {
            return new ERPPayment_term(obj);
        }
    }
}