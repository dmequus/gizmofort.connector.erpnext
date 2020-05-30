using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_receipt
{
    public class Purchase_receiptService : SubServiceBase<ERPPurchase_receipt>
    {
        public Purchase_receiptService(ERPNextClient client)
            : base(DocType.Purchase_receipt, client) { }

        protected override ERPPurchase_receipt fromERPObject(ERPObject obj)
        {
            return new ERPPurchase_receipt(obj);
        }
    }
}