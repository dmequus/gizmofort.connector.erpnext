using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Blanket_order
{
    public class Blanket_orderService : SubServiceBase<ERPBlanket_order>
    {
        public Blanket_orderService(ERPNextClient client)
            : base(DocType.Blanket_order, client) { }

        protected override ERPBlanket_order fromERPObject(ERPObject obj)
        {
            return new ERPBlanket_order(obj);
        }
    }
}