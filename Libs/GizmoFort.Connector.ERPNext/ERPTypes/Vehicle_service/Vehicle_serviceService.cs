using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Vehicle_service
{
    public class Vehicle_serviceService : SubServiceBase<ERPVehicle_service>
    {
        public Vehicle_serviceService(ERPNextClient client)
            : base(DocType.Vehicle_service, client) { }

        protected override ERPVehicle_service fromERPObject(ERPObject obj)
        {
            return new ERPVehicle_service(obj);
        }
    }
}