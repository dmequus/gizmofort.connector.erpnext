using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Linkedin_settings
{
    public class Linkedin_settingsService : SubServiceBase<ERPLinkedin_settings>
    {
        public Linkedin_settingsService(ERPNextClient client)
            : base(DocType.Linkedin_settings, client) { }

        protected override ERPLinkedin_settings fromERPObject(ERPObject obj)
        {
            return new ERPLinkedin_settings(obj);
        }
    }
}