using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_meeting_minutes
{
    public class Quality_meeting_minutesService : SubServiceBase<ERPQuality_meeting_minutes>
    {
        public Quality_meeting_minutesService(ERPNextClient client)
            : base(DocType.Quality_meeting_minutes, client) { }

        protected override ERPQuality_meeting_minutes fromERPObject(ERPObject obj)
        {
            return new ERPQuality_meeting_minutes(obj);
        }
    }
}