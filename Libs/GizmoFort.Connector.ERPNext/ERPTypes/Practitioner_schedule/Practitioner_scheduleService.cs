using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Practitioner_schedule
{
    public class Practitioner_scheduleService : SubServiceBase<ERPPractitioner_schedule>
    {
        public Practitioner_scheduleService(ERPNextClient client)
            : base(DocType.Practitioner_schedule, client) { }

        protected override ERPPractitioner_schedule fromERPObject(ERPObject obj)
        {
            return new ERPPractitioner_schedule(obj);
        }
    }
}