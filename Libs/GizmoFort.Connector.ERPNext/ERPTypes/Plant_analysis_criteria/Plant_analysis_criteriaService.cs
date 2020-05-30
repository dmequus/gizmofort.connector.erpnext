using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Plant_analysis_criteria
{
    public class Plant_analysis_criteriaService : SubServiceBase<ERPPlant_analysis_criteria>
    {
        public Plant_analysis_criteriaService(ERPNextClient client)
            : base(DocType.Plant_analysis_criteria, client) { }

        protected override ERPPlant_analysis_criteria fromERPObject(ERPObject obj)
        {
            return new ERPPlant_analysis_criteria(obj);
        }
    }
}