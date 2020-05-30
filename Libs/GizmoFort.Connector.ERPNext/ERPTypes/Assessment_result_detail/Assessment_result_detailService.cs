using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_result_detail
{
    public class Assessment_result_detailService : SubServiceBase<ERPAssessment_result_detail>
    {
        public Assessment_result_detailService(ERPNextClient client)
            : base(DocType.Assessment_result_detail, client) { }

        protected override ERPAssessment_result_detail fromERPObject(ERPObject obj)
        {
            return new ERPAssessment_result_detail(obj);
        }
    }
}