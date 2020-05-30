using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock_reconciliation
{
    public class Stock_reconciliationService : SubServiceBase<ERPStock_reconciliation>
    {
        public Stock_reconciliationService(ERPNextClient client)
            : base(DocType.Stock_reconciliation, client) { }

        protected override ERPStock_reconciliation fromERPObject(ERPObject obj)
        {
            return new ERPStock_reconciliation(obj);
        }
    }
}