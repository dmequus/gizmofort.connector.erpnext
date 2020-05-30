using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Availability_of_slots
{
    public class Availability_of_slotsService : SubServiceBase<ERPAvailability_of_slots>
    {
        public Availability_of_slotsService(ERPNextClient client)
            : base(DocType.Availability_of_slots, client) { }

        protected override ERPAvailability_of_slots fromERPObject(ERPObject obj)
        {
            return new ERPAvailability_of_slots(obj);
        }
    }
}