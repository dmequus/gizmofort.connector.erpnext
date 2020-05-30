using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_maintenance_task
{
    public class Asset_maintenance_taskService : SubServiceBase<ERPAsset_maintenance_task>
    {
        public Asset_maintenance_taskService(ERPNextClient client)
            : base(DocType.Asset_maintenance_task, client) { }

        protected override ERPAsset_maintenance_task fromERPObject(ERPObject obj)
        {
            return new ERPAsset_maintenance_task(obj);
        }
    }
}