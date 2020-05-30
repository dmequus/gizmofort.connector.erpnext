using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Production_plan_material_request
{
    public class Production_plan_material_requestService : SubServiceBase<ERPProduction_plan_material_request>
    {
        public Production_plan_material_requestService(ERPNextClient client)
            : base(DocType.Production_plan_material_request, client) { }

        protected override ERPProduction_plan_material_request fromERPObject(ERPObject obj)
        {
            return new ERPProduction_plan_material_request(obj);
        }
    }
}