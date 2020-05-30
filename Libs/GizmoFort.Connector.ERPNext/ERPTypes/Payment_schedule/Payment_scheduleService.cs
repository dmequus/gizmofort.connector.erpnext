using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_schedule
{
    public class Payment_scheduleService : SubServiceBase<ERPPayment_schedule>
    {
        public Payment_scheduleService(ERPNextClient client)
            : base(DocType.Payment_schedule, client) { }

        protected override ERPPayment_schedule fromERPObject(ERPObject obj)
        {
            return new ERPPayment_schedule(obj);
        }
    }
}