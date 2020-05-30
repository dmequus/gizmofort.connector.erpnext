using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Certified_consultant
{
    public class Certified_consultantService : SubServiceBase<ERPCertified_consultant>
    {
        public Certified_consultantService(ERPNextClient client)
            : base(DocType.Certified_consultant, client) { }

        protected override ERPCertified_consultant fromERPObject(ERPObject obj)
        {
            return new ERPCertified_consultant(obj);
        }
    }
}