using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Opening_invoice_creation_tool_item
{
    public class Opening_invoice_creation_tool_itemService : SubServiceBase<ERPOpening_invoice_creation_tool_item>
    {
        public Opening_invoice_creation_tool_itemService(ERPNextClient client)
            : base(DocType.Opening_invoice_creation_tool_item, client) { }

        protected override ERPOpening_invoice_creation_tool_item fromERPObject(ERPObject obj)
        {
            return new ERPOpening_invoice_creation_tool_item(obj);
        }
    }
}