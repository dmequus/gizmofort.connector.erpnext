using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_schedule_detail
{
    public class Maintenance_schedule_detailService : SubServiceBase<ERPMaintenance_schedule_detail>
    {
        public Maintenance_schedule_detailService(ERPNextClient client)
            : base(DocType.Maintenance_schedule_detail, client) { }

        protected override ERPMaintenance_schedule_detail fromERPObject(ERPObject obj)
        {
            return new ERPMaintenance_schedule_detail(obj);
        }
    }
}