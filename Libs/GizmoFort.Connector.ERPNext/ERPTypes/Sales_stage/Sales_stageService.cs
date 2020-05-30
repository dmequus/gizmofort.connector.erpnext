using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_stage
{
    public class Sales_stageService : SubServiceBase<ERPSales_stage>
    {
        public Sales_stageService(ERPNextClient client)
            : base(DocType.Sales_stage, client) { }

        protected override ERPSales_stage fromERPObject(ERPObject obj)
        {
            return new ERPSales_stage(obj);
        }
    }
}