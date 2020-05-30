using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Production_plan_material_request_warehouse
{
    public class Production_plan_material_request_warehouseService : SubServiceBase<ERPProduction_plan_material_request_warehouse>
    {
        public Production_plan_material_request_warehouseService(ERPNextClient client)
            : base(DocType.Production_plan_material_request_warehouse, client) { }

        protected override ERPProduction_plan_material_request_warehouse fromERPObject(ERPObject obj)
        {
            return new ERPProduction_plan_material_request_warehouse(obj);
        }
    }
}