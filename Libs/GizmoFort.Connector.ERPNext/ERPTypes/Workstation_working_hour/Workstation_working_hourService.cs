using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Workstation_working_hour
{
    public class Workstation_working_hourService : SubServiceBase<ERPWorkstation_working_hour>
    {
        public Workstation_working_hourService(ERPNextClient client)
            : base(DocType.Workstation_working_hour, client) { }

        protected override ERPWorkstation_working_hour fromERPObject(ERPObject obj)
        {
            return new ERPWorkstation_working_hour(obj);
        }
    }
}