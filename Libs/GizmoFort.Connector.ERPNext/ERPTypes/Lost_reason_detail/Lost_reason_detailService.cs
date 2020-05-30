using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Lost_reason_detail
{
    public class Lost_reason_detailService : SubServiceBase<ERPLost_reason_detail>
    {
        public Lost_reason_detailService(ERPNextClient client)
            : base(DocType.Lost_reason_detail, client) { }

        protected override ERPLost_reason_detail fromERPObject(ERPObject obj)
        {
            return new ERPLost_reason_detail(obj);
        }
    }
}