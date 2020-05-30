using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Practitioner_service_unit_schedule
{
    public class Practitioner_service_unit_scheduleService : SubServiceBase<ERPPractitioner_service_unit_schedule>
    {
        public Practitioner_service_unit_scheduleService(ERPNextClient client)
            : base(DocType.Practitioner_service_unit_schedule, client) { }

        protected override ERPPractitioner_service_unit_schedule fromERPObject(ERPObject obj)
        {
            return new ERPPractitioner_service_unit_schedule(obj);
        }
    }
}