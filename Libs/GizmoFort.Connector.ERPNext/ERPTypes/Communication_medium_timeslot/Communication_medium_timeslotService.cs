using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Communication_medium_timeslot
{
    public class Communication_medium_timeslotService : SubServiceBase<ERPCommunication_medium_timeslot>
    {
        public Communication_medium_timeslotService(ERPNextClient client)
            : base(DocType.Communication_medium_timeslot, client) { }

        protected override ERPCommunication_medium_timeslot fromERPObject(ERPObject obj)
        {
            return new ERPCommunication_medium_timeslot(obj);
        }
    }
}