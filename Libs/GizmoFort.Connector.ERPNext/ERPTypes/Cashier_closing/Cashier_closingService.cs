using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Cashier_closing
{
    public class Cashier_closingService : SubServiceBase<ERPCashier_closing>
    {
        public Cashier_closingService(ERPNextClient client)
            : base(DocType.Cashier_closing, client) { }

        protected override ERPCashier_closing fromERPObject(ERPObject obj)
        {
            return new ERPCashier_closing(obj);
        }
    }
}