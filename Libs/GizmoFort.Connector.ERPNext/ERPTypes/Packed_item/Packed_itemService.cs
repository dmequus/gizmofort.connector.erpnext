using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Packed_item
{
    public class Packed_itemService : SubServiceBase<ERPPacked_item>
    {
        public Packed_itemService(ERPNextClient client)
            : base(DocType.Packed_item, client) { }

        protected override ERPPacked_item fromERPObject(ERPObject obj)
        {
            return new ERPPacked_item(obj);
        }
    }
}