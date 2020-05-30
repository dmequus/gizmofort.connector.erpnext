using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Share_transfer
{
    public class Share_transferService : SubServiceBase<ERPShare_transfer>
    {
        public Share_transferService(ERPNextClient client)
            : base(DocType.Share_transfer, client) { }

        protected override ERPShare_transfer fromERPObject(ERPObject obj)
        {
            return new ERPShare_transfer(obj);
        }
    }
}