using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Soil_analysis_criteria
{
    public class Soil_analysis_criteriaService : SubServiceBase<ERPSoil_analysis_criteria>
    {
        public Soil_analysis_criteriaService(ERPNextClient client)
            : base(DocType.Soil_analysis_criteria, client) { }

        protected override ERPSoil_analysis_criteria fromERPObject(ERPObject obj)
        {
            return new ERPSoil_analysis_criteria(obj);
        }
    }
}