using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Opening_invoice_creation_tool
{
    public class Opening_invoice_creation_toolService : SubServiceBase<ERPOpening_invoice_creation_tool>
    {
        public Opening_invoice_creation_toolService(ERPNextClient client)
            : base(DocType.Opening_invoice_creation_tool, client) { }

        protected override ERPOpening_invoice_creation_tool fromERPObject(ERPObject obj)
        {
            return new ERPOpening_invoice_creation_tool(obj);
        }
    }
}