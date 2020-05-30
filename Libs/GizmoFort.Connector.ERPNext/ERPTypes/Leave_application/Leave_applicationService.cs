using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_application
{
    public class Leave_applicationService : SubServiceBase<ERPLeave_application>
    {
        public Leave_applicationService(ERPNextClient client)
            : base(DocType.Leave_application, client) { }

        protected override ERPLeave_application fromERPObject(ERPObject obj)
        {
            return new ERPLeave_application(obj);
        }
    }
}