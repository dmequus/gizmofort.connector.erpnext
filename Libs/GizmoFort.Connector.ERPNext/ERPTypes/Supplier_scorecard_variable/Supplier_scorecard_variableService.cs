using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_variable
{
    public class Supplier_scorecard_variableService : SubServiceBase<ERPSupplier_scorecard_variable>
    {
        public Supplier_scorecard_variableService(ERPNextClient client)
            : base(DocType.Supplier_scorecard_variable, client) { }

        protected override ERPSupplier_scorecard_variable fromERPObject(ERPObject obj)
        {
            return new ERPSupplier_scorecard_variable(obj);
        }
    }
}