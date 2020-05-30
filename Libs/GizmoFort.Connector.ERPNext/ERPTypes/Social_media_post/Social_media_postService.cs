using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Social_media_post
{
    public class Social_media_postService : SubServiceBase<ERPSocial_media_post>
    {
        public Social_media_postService(ERPNextClient client)
            : base(DocType.Social_media_post, client) { }

        protected override ERPSocial_media_post fromERPObject(ERPObject obj)
        {
            return new ERPSocial_media_post(obj);
        }
    }
}