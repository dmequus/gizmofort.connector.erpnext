using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quiz_activity
{
    public class Quiz_activityService : SubServiceBase<ERPQuiz_activity>
    {
        public Quiz_activityService(ERPNextClient client)
            : base(DocType.Quiz_activity, client) { }

        protected override ERPQuiz_activity fromERPObject(ERPObject obj)
        {
            return new ERPQuiz_activity(obj);
        }
    }
}