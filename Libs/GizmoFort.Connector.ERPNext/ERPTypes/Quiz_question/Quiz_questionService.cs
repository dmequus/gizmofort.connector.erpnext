using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quiz_question
{
    public class Quiz_questionService : SubServiceBase<ERPQuiz_question>
    {
        public Quiz_questionService(ERPNextClient client)
            : base(DocType.Quiz_question, client) { }

        protected override ERPQuiz_question fromERPObject(ERPObject obj)
        {
            return new ERPQuiz_question(obj);
        }
    }
}