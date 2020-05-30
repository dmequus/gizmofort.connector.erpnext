using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_order
{
    public class Sales_orderService : SubServiceBase<ERPSales_order>
    {
        public Sales_orderService(ERPNextClient client)
            : base(DocType.Sales_order, client) { }

        protected override ERPSales_order fromERPObject(ERPObject obj)
        {
            return new ERPSales_order(obj);
        }
    }
}