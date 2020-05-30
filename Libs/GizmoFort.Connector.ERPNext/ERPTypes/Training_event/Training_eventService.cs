using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Training_event
{
    public class Training_eventService : SubServiceBase<ERPTraining_event>
    {
        public Training_eventService(ERPNextClient client)
            : base(DocType.Training_event, client) { }

        protected override ERPTraining_event fromERPObject(ERPObject obj)
        {
            return new ERPTraining_event(obj);
        }
    }
}