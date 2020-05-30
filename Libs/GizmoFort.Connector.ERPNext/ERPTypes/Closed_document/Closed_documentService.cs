using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Closed_document
{
    public class Closed_documentService : SubServiceBase<ERPClosed_document>
    {
        public Closed_documentService(ERPNextClient client)
            : base(DocType.Closed_document, client) { }

        protected override ERPClosed_document fromERPObject(ERPObject obj)
        {
            return new ERPClosed_document(obj);
        }
    }
}