using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Body_part
{
    public class Body_partService : SubServiceBase<ERPBody_part>
    {
        public Body_partService(ERPNextClient client)
            : base(DocType.Body_part, client) { }

        protected override ERPBody_part fromERPObject(ERPObject obj)
        {
            return new ERPBody_part(obj);
        }
    }
}