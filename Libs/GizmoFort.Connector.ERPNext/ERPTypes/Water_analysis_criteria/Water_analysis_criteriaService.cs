using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Water_analysis_criteria
{
    public class Water_analysis_criteriaService : SubServiceBase<ERPWater_analysis_criteria>
    {
        public Water_analysis_criteriaService(ERPNextClient client)
            : base(DocType.Water_analysis_criteria, client) { }

        protected override ERPWater_analysis_criteria fromERPObject(ERPObject obj)
        {
            return new ERPWater_analysis_criteria(obj);
        }
    }
}