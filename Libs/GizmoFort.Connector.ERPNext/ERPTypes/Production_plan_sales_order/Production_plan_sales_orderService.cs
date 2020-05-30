using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Production_plan_sales_order
{
    public class Production_plan_sales_orderService : SubServiceBase<ERPProduction_plan_sales_order>
    {
        public Production_plan_sales_orderService(ERPNextClient client)
            : base(DocType.Production_plan_sales_order, client) { }

        protected override ERPProduction_plan_sales_order fromERPObject(ERPObject obj)
        {
            return new ERPProduction_plan_sales_order(obj);
        }
    }
}