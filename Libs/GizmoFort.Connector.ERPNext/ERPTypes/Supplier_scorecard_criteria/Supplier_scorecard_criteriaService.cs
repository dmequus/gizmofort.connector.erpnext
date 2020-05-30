using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_criteria
{
    public class Supplier_scorecard_criteriaService : SubServiceBase<ERPSupplier_scorecard_criteria>
    {
        public Supplier_scorecard_criteriaService(ERPNextClient client)
            : base(DocType.Supplier_scorecard_criteria, client) { }

        protected override ERPSupplier_scorecard_criteria fromERPObject(ERPObject obj)
        {
            return new ERPSupplier_scorecard_criteria(obj);
        }
    }
}