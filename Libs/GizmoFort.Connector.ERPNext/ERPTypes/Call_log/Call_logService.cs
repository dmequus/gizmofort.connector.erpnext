using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Call_log
{
    public class Call_logService : SubServiceBase<ERPCall_log>
    {
        public Call_logService(ERPNextClient client)
            : base(DocType.Call_log, client) { }

        protected override ERPCall_log fromERPObject(ERPObject obj)
        {
            return new ERPCall_log(obj);
        }
    }
}