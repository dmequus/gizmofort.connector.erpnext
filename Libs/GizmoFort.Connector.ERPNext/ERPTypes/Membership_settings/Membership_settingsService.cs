using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Membership_settings
{
    public class Membership_settingsService : SubServiceBase<ERPMembership_settings>
    {
        public Membership_settingsService(ERPNextClient client)
            : base(DocType.Membership_settings, client) { }

        protected override ERPMembership_settings fromERPObject(ERPObject obj)
        {
            return new ERPMembership_settings(obj);
        }
    }
}