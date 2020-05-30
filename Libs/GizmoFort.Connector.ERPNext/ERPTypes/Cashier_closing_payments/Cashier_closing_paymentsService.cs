using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Cashier_closing_payments
{
    public class Cashier_closing_paymentsService : SubServiceBase<ERPCashier_closing_payments>
    {
        public Cashier_closing_paymentsService(ERPNextClient client)
            : base(DocType.Cashier_closing_payments, client) { }

        protected override ERPCashier_closing_payments fromERPObject(ERPObject obj)
        {
            return new ERPCashier_closing_payments(obj);
        }
    }
}