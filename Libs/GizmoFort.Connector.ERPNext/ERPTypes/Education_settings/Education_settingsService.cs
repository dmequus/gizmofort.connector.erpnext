using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Education_settings
{
    public class Education_settingsService : SubServiceBase<ERPEducation_settings>
    {
        public Education_settingsService(ERPNextClient client)
            : base(DocType.Education_settings, client) { }

        protected override ERPEducation_settings fromERPObject(ERPObject obj)
        {
            return new ERPEducation_settings(obj);
        }
    }
}