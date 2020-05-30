using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Quiz_result
{
    public class Quiz_resultService : SubServiceBase<ERPQuiz_result>
    {
        public Quiz_resultService(ERPNextClient client)
            : base(DocType.Quiz_result, client) { }

        protected override ERPQuiz_result fromERPObject(ERPObject obj)
        {
            return new ERPQuiz_result(obj);
        }
    }
}