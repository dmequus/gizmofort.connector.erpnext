using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Location
{
    public class LocationService : SubServiceBase<ERPLocation>
    {
        public LocationService(ERPNextClient client)
            : base(DocType.Location, client) { }

        protected override ERPLocation fromERPObject(ERPObject obj)
        {
            return new ERPLocation(obj);
        }
    }
}