using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Delivery_note_item
{
    public class Delivery_note_itemService : SubServiceBase<ERPDelivery_note_item>
    {
        public Delivery_note_itemService(ERPNextClient client)
            : base(DocType.Delivery_note_item, client) { }

        protected override ERPDelivery_note_item fromERPObject(ERPObject obj)
        {
            return new ERPDelivery_note_item(obj);
        }
    }
}