using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_meeting
{
    public class Quality_meetingService : SubServiceBase<ERPQuality_meeting>
    {
        public Quality_meetingService(ERPNextClient client)
            : base(DocType.Quality_meeting, client) { }

        protected override ERPQuality_meeting fromERPObject(ERPObject obj)
        {
            return new ERPQuality_meeting(obj);
        }
    }
}