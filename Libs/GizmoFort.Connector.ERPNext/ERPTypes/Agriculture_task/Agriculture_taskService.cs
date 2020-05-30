using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Agriculture_task
{
    public class Agriculture_taskService : SubServiceBase<ERPAgriculture_task>
    {
        public Agriculture_taskService(ERPNextClient client)
            : base(DocType.Agriculture_task, client) { }

        protected override ERPAgriculture_task fromERPObject(ERPObject obj)
        {
            return new ERPAgriculture_task(obj);
        }
    }
}