using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Homepage
{
    public class HomepageService : SubServiceBase<ERPHomepage>
    {
        public HomepageService(ERPNextClient client)
            : base(DocType.Homepage, client) { }

        protected override ERPHomepage fromERPObject(ERPObject obj)
        {
            return new ERPHomepage(obj);
        }
    }
}