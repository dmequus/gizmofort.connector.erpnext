using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quality_feedback_parameter
{
    public class Quality_feedback_parameterService : SubServiceBase<ERPQuality_feedback_parameter>
    {
        public Quality_feedback_parameterService(ERPNextClient client)
            : base(DocType.Quality_feedback_parameter, client) { }

        protected override ERPQuality_feedback_parameter fromERPObject(ERPObject obj)
        {
            return new ERPQuality_feedback_parameter(obj);
        }
    }
}