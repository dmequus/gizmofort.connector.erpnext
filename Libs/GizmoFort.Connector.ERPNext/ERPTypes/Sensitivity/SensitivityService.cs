using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sensitivity
{
    public class SensitivityService : SubServiceBase<ERPSensitivity>
    {
        public SensitivityService(ERPNextClient client)
            : base(DocType.Sensitivity, client) { }

        protected override ERPSensitivity fromERPObject(ERPObject obj)
        {
            return new ERPSensitivity(obj);
        }
    }
}