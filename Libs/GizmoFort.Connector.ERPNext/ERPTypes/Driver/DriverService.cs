using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Driver
{
    public class DriverService : SubServiceBase<ERPDriver>
    {
        public DriverService(ERPNextClient client)
            : base(DocType.Driver, client) { }

        protected override ERPDriver fromERPObject(ERPObject obj)
        {
            return new ERPDriver(obj);
        }
    }
}