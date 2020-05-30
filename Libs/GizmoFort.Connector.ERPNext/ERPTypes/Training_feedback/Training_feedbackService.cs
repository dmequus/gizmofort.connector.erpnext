using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Training_feedback
{
    public class Training_feedbackService : SubServiceBase<ERPTraining_feedback>
    {
        public Training_feedbackService(ERPNextClient client)
            : base(DocType.Training_feedback, client) { }

        protected override ERPTraining_feedback fromERPObject(ERPObject obj)
        {
            return new ERPTraining_feedback(obj);
        }
    }
}