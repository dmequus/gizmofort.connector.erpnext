using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quotation_lost_reason
{
    public class Quotation_lost_reasonService : SubServiceBase<ERPQuotation_lost_reason>
    {
        public Quotation_lost_reasonService(ERPNextClient client)
            : base(DocType.Quotation_lost_reason, client) { }

        protected override ERPQuotation_lost_reason fromERPObject(ERPObject obj)
        {
            return new ERPQuotation_lost_reason(obj);
        }
    }
}