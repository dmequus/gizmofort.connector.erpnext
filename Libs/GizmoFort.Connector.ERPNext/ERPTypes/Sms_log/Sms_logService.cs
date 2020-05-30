using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sms_log
{
    public class Sms_logService : SubServiceBase<ERPSms_log>
    {
        public Sms_logService(ERPNextClient client)
            : base(DocType.Sms_log, client) { }

        protected override ERPSms_log fromERPObject(ERPObject obj)
        {
            return new ERPSms_log(obj);
        }
    }
}