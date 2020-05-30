using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Healthcare_settings
{
    public class Healthcare_settingsService : SubServiceBase<ERPHealthcare_settings>
    {
        public Healthcare_settingsService(ERPNextClient client)
            : base(DocType.Healthcare_settings, client) { }

        protected override ERPHealthcare_settings fromERPObject(ERPObject obj)
        {
            return new ERPHealthcare_settings(obj);
        }
    }
}