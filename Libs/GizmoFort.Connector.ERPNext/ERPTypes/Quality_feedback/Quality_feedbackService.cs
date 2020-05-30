using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_feedback
{
    public class Quality_feedbackService : SubServiceBase<ERPQuality_feedback>
    {
        public Quality_feedbackService(ERPNextClient client)
            : base(DocType.Quality_feedback, client) { }

        protected override ERPQuality_feedback fromERPObject(ERPObject obj)
        {
            return new ERPQuality_feedback(obj);
        }
    }
}