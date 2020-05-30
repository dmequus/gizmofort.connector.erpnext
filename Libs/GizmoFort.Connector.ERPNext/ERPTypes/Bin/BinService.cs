using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bin
{
    public class BinService : SubServiceBase<ERPBin>
    {
        public BinService(ERPNextClient client)
            : base(DocType.Bin, client) { }

        protected override ERPBin fromERPObject(ERPObject obj)
        {
            return new ERPBin(obj);
        }
    }
}