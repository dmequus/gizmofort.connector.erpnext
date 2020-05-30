using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Delivery_note
{
    public class Delivery_noteService : SubServiceBase<ERPDelivery_note>
    {
        public Delivery_noteService(ERPNextClient client)
            : base(DocType.Delivery_note, client) { }

        protected override ERPDelivery_note fromERPObject(ERPObject obj)
        {
            return new ERPDelivery_note(obj);
        }
    }
}