using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Linked_location
{
    public class Linked_locationService : SubServiceBase<ERPLinked_location>
    {
        public Linked_locationService(ERPNextClient client)
            : base(DocType.Linked_location, client) { }

        protected override ERPLinked_location fromERPObject(ERPObject obj)
        {
            return new ERPLinked_location(obj);
        }
    }
}