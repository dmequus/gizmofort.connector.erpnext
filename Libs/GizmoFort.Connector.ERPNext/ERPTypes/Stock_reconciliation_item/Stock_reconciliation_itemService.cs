using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock_reconciliation_item
{
    public class Stock_reconciliation_itemService : SubServiceBase<ERPStock_reconciliation_item>
    {
        public Stock_reconciliation_itemService(ERPNextClient client)
            : base(DocType.Stock_reconciliation_item, client) { }

        protected override ERPStock_reconciliation_item fromERPObject(ERPObject obj)
        {
            return new ERPStock_reconciliation_item(obj);
        }
    }
}