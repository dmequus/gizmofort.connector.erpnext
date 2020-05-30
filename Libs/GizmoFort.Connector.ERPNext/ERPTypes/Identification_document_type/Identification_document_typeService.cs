using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Identification_document_type
{
    public class Identification_document_typeService : SubServiceBase<ERPIdentification_document_type>
    {
        public Identification_document_typeService(ERPNextClient client)
            : base(DocType.Identification_document_type, client) { }

        protected override ERPIdentification_document_type fromERPObject(ERPObject obj)
        {
            return new ERPIdentification_document_type(obj);
        }
    }
}