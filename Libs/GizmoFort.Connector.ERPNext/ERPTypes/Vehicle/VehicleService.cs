using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Vehicle
{
    public class VehicleService : SubServiceBase<ERPVehicle>
    {
        public VehicleService(ERPNextClient client)
            : base(DocType.Vehicle, client) { }

        protected override ERPVehicle fromERPObject(ERPObject obj)
        {
            return new ERPVehicle(obj);
        }
    }
}