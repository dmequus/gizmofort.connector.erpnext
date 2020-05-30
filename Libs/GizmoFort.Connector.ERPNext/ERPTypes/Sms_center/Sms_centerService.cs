using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sms_center
{
    public class Sms_centerService : SubServiceBase<ERPSms_center>
    {
        public Sms_centerService(ERPNextClient client)
            : base(DocType.Sms_center, client) { }

        protected override ERPSms_center fromERPObject(ERPObject obj)
        {
            return new ERPSms_center(obj);
        }
    }
}