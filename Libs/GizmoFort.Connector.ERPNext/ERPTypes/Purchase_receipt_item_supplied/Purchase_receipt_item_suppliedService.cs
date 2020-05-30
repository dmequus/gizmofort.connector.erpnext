using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_receipt_item_supplied
{
    public class Purchase_receipt_item_suppliedService : SubServiceBase<ERPPurchase_receipt_item_supplied>
    {
        public Purchase_receipt_item_suppliedService(ERPNextClient client)
            : base(DocType.Purchase_receipt_item_supplied, client) { }

        protected override ERPPurchase_receipt_item_supplied fromERPObject(ERPObject obj)
        {
            return new ERPPurchase_receipt_item_supplied(obj);
        }
    }
}