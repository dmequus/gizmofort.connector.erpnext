using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_feedback_template_parameter
{
    public class Quality_feedback_template_parameterService : SubServiceBase<ERPQuality_feedback_template_parameter>
    {
        public Quality_feedback_template_parameterService(ERPNextClient client)
            : base(DocType.Quality_feedback_template_parameter, client) { }

        protected override ERPQuality_feedback_template_parameter fromERPObject(ERPObject obj)
        {
            return new ERPQuality_feedback_template_parameter(obj);
        }
    }
}