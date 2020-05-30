using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Linked_soil_texture
{
    public class Linked_soil_textureService : SubServiceBase<ERPLinked_soil_texture>
    {
        public Linked_soil_textureService(ERPNextClient client)
            : base(DocType.Linked_soil_texture, client) { }

        protected override ERPLinked_soil_texture fromERPObject(ERPObject obj)
        {
            return new ERPLinked_soil_texture(obj);
        }
    }
}