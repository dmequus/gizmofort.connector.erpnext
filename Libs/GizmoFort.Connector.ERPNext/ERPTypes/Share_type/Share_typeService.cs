using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Share_type
{
    public class Share_typeService : SubServiceBase<ERPShare_type>
    {
        public Share_typeService(ERPNextClient client)
            : base(DocType.Share_type, client) { }

        protected override ERPShare_type fromERPObject(ERPObject obj)
        {
            return new ERPShare_type(obj);
        }
    }
}