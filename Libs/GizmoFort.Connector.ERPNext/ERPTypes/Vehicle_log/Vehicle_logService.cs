using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Vehicle_log
{
    public class Vehicle_logService : SubServiceBase<ERPVehicle_log>
    {
        public Vehicle_logService(ERPNextClient client)
            : base(DocType.Vehicle_log, client) { }

        protected override ERPVehicle_log fromERPObject(ERPObject obj)
        {
            return new ERPVehicle_log(obj);
        }
    }
}