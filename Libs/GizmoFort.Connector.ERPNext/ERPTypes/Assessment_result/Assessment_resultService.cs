using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_result
{
    public class Assessment_resultService : SubServiceBase<ERPAssessment_result>
    {
        public Assessment_resultService(ERPNextClient client)
            : base(DocType.Assessment_result, client) { }

        protected override ERPAssessment_result fromERPObject(ERPObject obj)
        {
            return new ERPAssessment_result(obj);
        }
    }
}