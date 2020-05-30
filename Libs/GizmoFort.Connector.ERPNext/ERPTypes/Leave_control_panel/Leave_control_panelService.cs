using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Leave_control_panel
{
    public class Leave_control_panelService : SubServiceBase<ERPLeave_control_panel>
    {
        public Leave_control_panelService(ERPNextClient client)
            : base(DocType.Leave_control_panel, client) { }

        protected override ERPLeave_control_panel fromERPObject(ERPObject obj)
        {
            return new ERPLeave_control_panel(obj);
        }
    }
}