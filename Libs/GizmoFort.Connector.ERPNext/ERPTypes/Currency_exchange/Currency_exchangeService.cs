using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Currency_exchange
{
    public class Currency_exchangeService : SubServiceBase<ERPCurrency_exchange>
    {
        public Currency_exchangeService(ERPNextClient client)
            : base(DocType.Currency_exchange, client) { }

        protected override ERPCurrency_exchange fromERPObject(ERPObject obj)
        {
            return new ERPCurrency_exchange(obj);
        }
    }
}