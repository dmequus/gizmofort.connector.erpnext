using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Soil_texture
{
    public class Soil_textureService : SubServiceBase<ERPSoil_texture>
    {
        public Soil_textureService(ERPNextClient client)
            : base(DocType.Soil_texture, client) { }

        protected override ERPSoil_texture fromERPObject(ERPObject obj)
        {
            return new ERPSoil_texture(obj);
        }
    }
}