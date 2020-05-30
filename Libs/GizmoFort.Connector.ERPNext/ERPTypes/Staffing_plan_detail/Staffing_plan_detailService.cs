using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Staffing_plan_detail
{
    public class Staffing_plan_detailService : SubServiceBase<ERPStaffing_plan_detail>
    {
        public Staffing_plan_detailService(ERPNextClient client)
            : base(DocType.Staffing_plan_detail, client) { }

        protected override ERPStaffing_plan_detail fromERPObject(ERPObject obj)
        {
            return new ERPStaffing_plan_detail(obj);
        }
    }
}