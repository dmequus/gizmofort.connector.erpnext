using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Room
{
    public class RoomService : SubServiceBase<ERPRoom>
    {
        public RoomService(ERPNextClient client)
            : base(DocType.Room, client) { }

        protected override ERPRoom fromERPObject(ERPObject obj)
        {
            return new ERPRoom(obj);
        }
    }
}