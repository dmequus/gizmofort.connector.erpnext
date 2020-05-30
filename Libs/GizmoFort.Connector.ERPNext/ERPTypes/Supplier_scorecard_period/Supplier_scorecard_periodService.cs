using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_period
{
    public class Supplier_scorecard_periodService : SubServiceBase<ERPSupplier_scorecard_period>
    {
        public Supplier_scorecard_periodService(ERPNextClient client)
            : base(DocType.Supplier_scorecard_period, client) { }

        protected override ERPSupplier_scorecard_period fromERPObject(ERPObject obj)
        {
            return new ERPSupplier_scorecard_period(obj);
        }
    }
}