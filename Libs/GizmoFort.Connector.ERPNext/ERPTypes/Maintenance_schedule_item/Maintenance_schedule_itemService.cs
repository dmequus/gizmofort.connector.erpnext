using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_schedule_item
{
    public class Maintenance_schedule_itemService : SubServiceBase<ERPMaintenance_schedule_item>
    {
        public Maintenance_schedule_itemService(ERPNextClient client)
            : base(DocType.Maintenance_schedule_item, client) { }

        protected override ERPMaintenance_schedule_item fromERPObject(ERPObject obj)
        {
            return new ERPMaintenance_schedule_item(obj);
        }
    }
}