using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Healthcare_schedule_time_slot
{
    public class Healthcare_schedule_time_slotService : SubServiceBase<ERPHealthcare_schedule_time_slot>
    {
        public Healthcare_schedule_time_slotService(ERPNextClient client)
            : base(DocType.Healthcare_schedule_time_slot, client) { }

        protected override ERPHealthcare_schedule_time_slot fromERPObject(ERPObject obj)
        {
            return new ERPHealthcare_schedule_time_slot(obj);
        }
    }
}