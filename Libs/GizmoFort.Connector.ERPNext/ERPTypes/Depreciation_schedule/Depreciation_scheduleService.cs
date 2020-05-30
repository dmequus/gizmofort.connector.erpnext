using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Depreciation_schedule
{
    public class Depreciation_scheduleService : SubServiceBase<ERPDepreciation_schedule>
    {
        public Depreciation_scheduleService(ERPNextClient client)
            : base(DocType.Depreciation_schedule, client) { }

        protected override ERPDepreciation_schedule fromERPObject(ERPObject obj)
        {
            return new ERPDepreciation_schedule(obj);
        }
    }
}