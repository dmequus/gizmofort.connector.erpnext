using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Production_plan_item
{
    public class Production_plan_itemService : SubServiceBase<ERPProduction_plan_item>
    {
        public Production_plan_itemService(ERPNextClient client)
            : base(DocType.Production_plan_item, client) { }

        protected override ERPProduction_plan_item fromERPObject(ERPObject obj)
        {
            return new ERPProduction_plan_item(obj);
        }
    }
}