using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Certification_application
{
    public class Certification_applicationService : SubServiceBase<ERPCertification_application>
    {
        public Certification_applicationService(ERPNextClient client)
            : base(DocType.Certification_application, client) { }

        protected override ERPCertification_application fromERPObject(ERPObject obj)
        {
            return new ERPCertification_application(obj);
        }
    }
}