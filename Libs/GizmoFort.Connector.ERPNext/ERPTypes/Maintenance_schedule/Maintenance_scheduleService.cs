using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_schedule
{
    public class Maintenance_scheduleService : SubServiceBase<ERPMaintenance_schedule>
    {
        public Maintenance_scheduleService(ERPNextClient client)
            : base(DocType.Maintenance_schedule, client) { }

        protected override ERPMaintenance_schedule fromERPObject(ERPObject obj)
        {
            return new ERPMaintenance_schedule(obj);
        }
    }
}