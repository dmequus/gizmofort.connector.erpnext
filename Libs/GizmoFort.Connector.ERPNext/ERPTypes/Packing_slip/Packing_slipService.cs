using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Packing_slip
{
    public class Packing_slipService : SubServiceBase<ERPPacking_slip>
    {
        public Packing_slipService(ERPNextClient client)
            : base(DocType.Packing_slip, client) { }

        protected override ERPPacking_slip fromERPObject(ERPObject obj)
        {
            return new ERPPacking_slip(obj);
        }
    }
}