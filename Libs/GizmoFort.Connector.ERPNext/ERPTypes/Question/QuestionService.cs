using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Question
{
    public class QuestionService : SubServiceBase<ERPQuestion>
    {
        public QuestionService(ERPNextClient client)
            : base(DocType.Question, client) { }

        protected override ERPQuestion fromERPObject(ERPObject obj)
        {
            return new ERPQuestion(obj);
        }
    }
}