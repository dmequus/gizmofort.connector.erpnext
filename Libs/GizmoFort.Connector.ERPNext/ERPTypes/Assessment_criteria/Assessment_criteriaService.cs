using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assessment_criteria
{
    public class Assessment_criteriaService : SubServiceBase<ERPAssessment_criteria>
    {
        public Assessment_criteriaService(ERPNextClient client)
            : base(DocType.Assessment_criteria, client) { }

        protected override ERPAssessment_criteria fromERPObject(ERPObject obj)
        {
            return new ERPAssessment_criteria(obj);
        }
    }
}