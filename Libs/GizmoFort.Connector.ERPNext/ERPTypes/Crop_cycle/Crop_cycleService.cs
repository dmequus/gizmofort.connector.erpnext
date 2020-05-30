using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Crop_cycle
{
    public class Crop_cycleService : SubServiceBase<ERPCrop_cycle>
    {
        public Crop_cycleService(ERPNextClient client)
            : base(DocType.Crop_cycle, client) { }

        protected override ERPCrop_cycle fromERPObject(ERPObject obj)
        {
            return new ERPCrop_cycle(obj);
        }
    }
}