using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Projects_settings
{
    public class Projects_settingsService : SubServiceBase<ERPProjects_settings>
    {
        public Projects_settingsService(ERPNextClient client)
            : base(DocType.Projects_settings, client) { }

        protected override ERPProjects_settings fromERPObject(ERPObject obj)
        {
            return new ERPProjects_settings(obj);
        }
    }
}