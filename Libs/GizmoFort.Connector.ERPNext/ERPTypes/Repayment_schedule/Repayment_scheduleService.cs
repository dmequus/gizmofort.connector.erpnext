using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Repayment_schedule
{
    public class Repayment_scheduleService : SubServiceBase<ERPRepayment_schedule>
    {
        public Repayment_scheduleService(ERPNextClient client)
            : base(DocType.Repayment_schedule, client) { }

        protected override ERPRepayment_schedule fromERPObject(ERPObject obj)
        {
            return new ERPRepayment_schedule(obj);
        }
    }
}