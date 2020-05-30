using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quotation
{
    public class QuotationService : SubServiceBase<ERPQuotation>
    {
        public QuotationService(ERPNextClient client)
            : base(DocType.Quotation, client) { }

        protected override ERPQuotation fromERPObject(ERPObject obj)
        {
            return new ERPQuotation(obj);
        }
    }
}