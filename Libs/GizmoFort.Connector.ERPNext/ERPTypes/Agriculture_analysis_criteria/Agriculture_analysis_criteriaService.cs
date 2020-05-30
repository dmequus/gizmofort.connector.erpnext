using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Agriculture_analysis_criteria
{
    public class Agriculture_analysis_criteriaService : SubServiceBase<ERPAgriculture_analysis_criteria>
    {
        public Agriculture_analysis_criteriaService(ERPNextClient client)
            : base(DocType.Agriculture_analysis_criteria, client) { }

        protected override ERPAgriculture_analysis_criteria fromERPObject(ERPObject obj)
        {
            return new ERPAgriculture_analysis_criteria(obj);
        }
    }
}