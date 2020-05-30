using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_settings
{
    public class Pos_settingsService : SubServiceBase<ERPPos_settings>
    {
        public Pos_settingsService(ERPNextClient client)
            : base(DocType.Pos_settings, client) { }

        protected override ERPPos_settings fromERPObject(ERPObject obj)
        {
            return new ERPPos_settings(obj);
        }
    }
}