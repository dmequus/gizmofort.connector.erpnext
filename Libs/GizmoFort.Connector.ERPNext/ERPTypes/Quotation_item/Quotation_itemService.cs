using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quotation_item
{
    public class Quotation_itemService : SubServiceBase<ERPQuotation_item>
    {
        public Quotation_itemService(ERPNextClient client)
            : base(DocType.Quotation_item, client) { }

        protected override ERPQuotation_item fromERPObject(ERPObject obj)
        {
            return new ERPQuotation_item(obj);
        }
    }
}