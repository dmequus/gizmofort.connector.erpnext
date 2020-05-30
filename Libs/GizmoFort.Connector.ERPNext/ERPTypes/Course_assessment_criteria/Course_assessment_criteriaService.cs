using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Course_assessment_criteria
{
    public class Course_assessment_criteriaService : SubServiceBase<ERPCourse_assessment_criteria>
    {
        public Course_assessment_criteriaService(ERPNextClient client)
            : base(DocType.Course_assessment_criteria, client) { }

        protected override ERPCourse_assessment_criteria fromERPObject(ERPObject obj)
        {
            return new ERPCourse_assessment_criteria(obj);
        }
    }
}