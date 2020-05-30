using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_feedback_template
{
    public class Quality_feedback_templateService : SubServiceBase<ERPQuality_feedback_template>
    {
        public Quality_feedback_templateService(ERPNextClient client)
            : base(DocType.Quality_feedback_template, client) { }

        protected override ERPQuality_feedback_template fromERPObject(ERPObject obj)
        {
            return new ERPQuality_feedback_template(obj);
        }
    }
}