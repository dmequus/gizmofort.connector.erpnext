using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_order_item
{
    public class Purchase_order_itemService : SubServiceBase<ERPPurchase_order_item>
    {
        public Purchase_order_itemService(ERPNextClient client)
            : base(DocType.Purchase_order_item, client) { }

        protected override ERPPurchase_order_item fromERPObject(ERPObject obj)
        {
            return new ERPPurchase_order_item(obj);
        }
    }
}