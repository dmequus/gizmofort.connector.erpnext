using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_order_item
{
    public class Sales_order_itemService : SubServiceBase<ERPSales_order_item>
    {
        public Sales_order_itemService(ERPNextClient client)
            : base(DocType.Sales_order_item, client) { }

        protected override ERPSales_order_item fromERPObject(ERPObject obj)
        {
            return new ERPSales_order_item(obj);
        }
    }
}