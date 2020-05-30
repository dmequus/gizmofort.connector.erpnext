using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Crop
{
    public class CropService : SubServiceBase<ERPCrop>
    {
        public CropService(ERPNextClient client)
            : base(DocType.Crop, client) { }

        protected override ERPCrop fromERPObject(ERPObject obj)
        {
            return new ERPCrop(obj);
        }
    }
}