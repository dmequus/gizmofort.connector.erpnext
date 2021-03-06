using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_order_item_supplied
{
    public class Purchase_order_item_suppliedService : SubServiceBase<ERPPurchase_order_item_supplied>
    {
        public Purchase_order_item_suppliedService(ERPNextClient client)
            : base(DocType.Purchase_order_item_supplied, client) { }

        protected override ERPPurchase_order_item_supplied fromERPObject(ERPObject obj)
        {
            return new ERPPurchase_order_item_supplied(obj);
        }
    }
}