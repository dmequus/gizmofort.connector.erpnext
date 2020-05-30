using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Blanket_order_item
{
    public class Blanket_order_itemService : SubServiceBase<ERPBlanket_order_item>
    {
        public Blanket_order_itemService(ERPNextClient client)
            : base(DocType.Blanket_order_item, client) { }

        protected override ERPBlanket_order_item fromERPObject(ERPObject obj)
        {
            return new ERPBlanket_order_item(obj);
        }
    }
}