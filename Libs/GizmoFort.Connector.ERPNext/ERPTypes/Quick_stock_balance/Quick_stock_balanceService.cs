using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quick_stock_balance
{
    public class Quick_stock_balanceService : SubServiceBase<ERPQuick_stock_balance>
    {
        public Quick_stock_balanceService(ERPNextClient client)
            : base(DocType.Quick_stock_balance, client) { }

        protected override ERPQuick_stock_balance fromERPObject(ERPObject obj)
        {
            return new ERPQuick_stock_balance(obj);
        }
    }
}