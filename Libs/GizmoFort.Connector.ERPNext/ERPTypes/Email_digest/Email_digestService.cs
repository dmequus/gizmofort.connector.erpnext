using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Email_digest
{
    public class Email_digestService : SubServiceBase<ERPEmail_digest>
    {
        public Email_digestService(ERPNextClient client)
            : base(DocType.Email_digest, client) { }

        protected override ERPEmail_digest fromERPObject(ERPObject obj)
        {
            return new ERPEmail_digest(obj);
        }
    }
}