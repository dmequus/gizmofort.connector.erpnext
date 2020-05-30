using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Purchase_order
{
    public class Purchase_orderService : SubServiceBase<ERPPurchase_order>
    {
        public Purchase_orderService(ERPNextClient client)
            : base(DocType.Purchase_order, client) { }

        protected override ERPPurchase_order fromERPObject(ERPObject obj)
        {
            return new ERPPurchase_order(obj);
        }
    }
}