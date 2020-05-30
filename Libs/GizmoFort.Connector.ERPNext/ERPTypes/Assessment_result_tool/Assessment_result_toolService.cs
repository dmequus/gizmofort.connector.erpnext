using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_result_tool
{
    public class Assessment_result_toolService : SubServiceBase<ERPAssessment_result_tool>
    {
        public Assessment_result_toolService(ERPNextClient client)
            : base(DocType.Assessment_result_tool, client) { }

        protected override ERPAssessment_result_tool fromERPObject(ERPObject obj)
        {
            return new ERPAssessment_result_tool(obj);
        }
    }
}