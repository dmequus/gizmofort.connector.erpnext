using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Packing_slip_item
{
    public class Packing_slip_itemService : SubServiceBase<ERPPacking_slip_item>
    {
        public Packing_slip_itemService(ERPNextClient client)
            : base(DocType.Packing_slip_item, client) { }

        protected override ERPPacking_slip_item fromERPObject(ERPObject obj)
        {
            return new ERPPacking_slip_item(obj);
        }
    }
}