using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Material_request_item
{
    public class Material_request_itemService : SubServiceBase<ERPMaterial_request_item>
    {
        public Material_request_itemService(ERPNextClient client)
            : base(DocType.Material_request_item, client) { }

        protected override ERPMaterial_request_item fromERPObject(ERPObject obj)
        {
            return new ERPMaterial_request_item(obj);
        }
    }
}