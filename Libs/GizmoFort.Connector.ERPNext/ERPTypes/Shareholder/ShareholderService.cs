using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Shareholder
{
    public class ShareholderService : SubServiceBase<ERPShareholder>
    {
        public ShareholderService(ERPNextClient client)
            : base(DocType.Shareholder, client) { }

        protected override ERPShareholder fromERPObject(ERPObject obj)
        {
            return new ERPShareholder(obj);
        }
    }
}