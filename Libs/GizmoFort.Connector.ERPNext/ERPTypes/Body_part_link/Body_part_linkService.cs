using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Body_part_link
{
    public class Body_part_linkService : SubServiceBase<ERPBody_part_link>
    {
        public Body_part_linkService(ERPNextClient client)
            : base(DocType.Body_part_link, client) { }

        protected override ERPBody_part_link fromERPObject(ERPObject obj)
        {
            return new ERPBody_part_link(obj);
        }
    }
}