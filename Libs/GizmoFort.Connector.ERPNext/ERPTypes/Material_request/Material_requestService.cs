using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Material_request
{
    public class Material_requestService : SubServiceBase<ERPMaterial_request>
    {
        public Material_requestService(ERPNextClient client)
            : base(DocType.Material_request, client) { }

        protected override ERPMaterial_request fromERPObject(ERPObject obj)
        {
            return new ERPMaterial_request(obj);
        }
    }
}