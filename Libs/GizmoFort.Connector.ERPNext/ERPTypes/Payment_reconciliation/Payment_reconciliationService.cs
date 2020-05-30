using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_reconciliation
{
    public class Payment_reconciliationService : SubServiceBase<ERPPayment_reconciliation>
    {
        public Payment_reconciliationService(ERPNextClient client)
            : base(DocType.Payment_reconciliation, client) { }

        protected override ERPPayment_reconciliation fromERPObject(ERPObject obj)
        {
            return new ERPPayment_reconciliation(obj);
        }
    }
}