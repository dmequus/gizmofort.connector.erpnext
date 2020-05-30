using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quiz
{
    public class QuizService : SubServiceBase<ERPQuiz>
    {
        public QuizService(ERPNextClient client)
            : base(DocType.Quiz, client) { }

        protected override ERPQuiz fromERPObject(ERPObject obj)
        {
            return new ERPQuiz(obj);
        }
    }
}