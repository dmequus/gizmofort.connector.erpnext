using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Production_plan
{
    public class Production_planService : SubServiceBase<ERPProduction_plan>
    {
        public Production_planService(ERPNextClient client)
            : base(DocType.Production_plan, client) { }

        protected override ERPProduction_plan fromERPObject(ERPObject obj)
        {
            return new ERPProduction_plan(obj);
        }
    }
}