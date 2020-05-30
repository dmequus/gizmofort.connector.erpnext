using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Landed_cost_purchase_receipt
{
    public class Landed_cost_purchase_receiptService : SubServiceBase<ERPLanded_cost_purchase_receipt>
    {
        public Landed_cost_purchase_receiptService(ERPNextClient client)
            : base(DocType.Landed_cost_purchase_receipt, client) { }

        protected override ERPLanded_cost_purchase_receipt fromERPObject(ERPObject obj)
        {
            return new ERPLanded_cost_purchase_receipt(obj);
        }
    }
}