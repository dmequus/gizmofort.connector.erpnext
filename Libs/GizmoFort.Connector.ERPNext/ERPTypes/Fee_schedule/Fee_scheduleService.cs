using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Fee_schedule
{
    public class Fee_scheduleService : SubServiceBase<ERPFee_schedule>
    {
        public Fee_scheduleService(ERPNextClient client)
            : base(DocType.Fee_schedule, client) { }

        protected override ERPFee_schedule fromERPObject(ERPObject obj)
        {
            return new ERPFee_schedule(obj);
        }
    }
}