using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_standing
{
    public class Supplier_scorecard_standingService : SubServiceBase<ERPSupplier_scorecard_standing>
    {
        public Supplier_scorecard_standingService(ERPNextClient client)
            : base(DocType.Supplier_scorecard_standing, client) { }

        protected override ERPSupplier_scorecard_standing fromERPObject(ERPObject obj)
        {
            return new ERPSupplier_scorecard_standing(obj);
        }
    }
}