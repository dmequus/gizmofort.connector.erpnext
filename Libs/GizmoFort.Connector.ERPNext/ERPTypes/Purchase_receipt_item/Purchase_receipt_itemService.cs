using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_receipt_item
{
    public class Purchase_receipt_itemService : SubServiceBase<ERPPurchase_receipt_item>
    {
        public Purchase_receipt_itemService(ERPNextClient client)
            : base(DocType.Purchase_receipt_item, client) { }

        protected override ERPPurchase_receipt_item fromERPObject(ERPObject obj)
        {
            return new ERPPurchase_receipt_item(obj);
        }
    }
}