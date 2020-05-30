using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard
{
    public class Supplier_scorecardService : SubServiceBase<ERPSupplier_scorecard>
    {
        public Supplier_scorecardService(ERPNextClient client)
            : base(DocType.Supplier_scorecard, client) { }

        protected override ERPSupplier_scorecard fromERPObject(ERPObject obj)
        {
            return new ERPSupplier_scorecard(obj);
        }
    }
}