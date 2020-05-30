using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_meeting_agenda
{
    public class Quality_meeting_agendaService : SubServiceBase<ERPQuality_meeting_agenda>
    {
        public Quality_meeting_agendaService(ERPNextClient client)
            : base(DocType.Quality_meeting_agenda, client) { }

        protected override ERPQuality_meeting_agenda fromERPObject(ERPObject obj)
        {
            return new ERPQuality_meeting_agenda(obj);
        }
    }
}