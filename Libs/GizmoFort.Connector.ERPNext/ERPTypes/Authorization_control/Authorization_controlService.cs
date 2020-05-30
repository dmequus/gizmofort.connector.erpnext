using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Authorization_control
{
    public class Authorization_controlService : SubServiceBase<ERPAuthorization_control>
    {
        public Authorization_controlService(ERPNextClient client)
            : base(DocType.Authorization_control, client) { }

        protected override ERPAuthorization_control fromERPObject(ERPObject obj)
        {
            return new ERPAuthorization_control(obj);
        }
    }
}