using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Content_question
{
    public class Content_questionService : SubServiceBase<ERPContent_question>
    {
        public Content_questionService(ERPNextClient client)
            : base(DocType.Content_question, client) { }

        protected override ERPContent_question fromERPObject(ERPObject obj)
        {
            return new ERPContent_question(obj);
        }
    }
}