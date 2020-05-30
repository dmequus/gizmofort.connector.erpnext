using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_scoring_criteria
{
    public class Supplier_scorecard_scoring_criteriaService : SubServiceBase<ERPSupplier_scorecard_scoring_criteria>
    {
        public Supplier_scorecard_scoring_criteriaService(ERPNextClient client)
            : base(DocType.Supplier_scorecard_scoring_criteria, client) { }

        protected override ERPSupplier_scorecard_scoring_criteria fromERPObject(ERPObject obj)
        {
            return new ERPSupplier_scorecard_scoring_criteria(obj);
        }
    }
}