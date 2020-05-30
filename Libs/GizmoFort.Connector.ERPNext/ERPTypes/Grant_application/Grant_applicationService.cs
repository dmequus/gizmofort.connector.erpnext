using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Grant_application
{
    public class Grant_applicationService : SubServiceBase<ERPGrant_application>
    {
        public Grant_applicationService(ERPNextClient client)
            : base(DocType.Grant_application, client) { }

        protected override ERPGrant_application fromERPObject(ERPObject obj)
        {
            return new ERPGrant_application(obj);
        }
    }
}