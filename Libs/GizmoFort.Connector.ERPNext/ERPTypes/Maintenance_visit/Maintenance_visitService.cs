using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_visit
{
    public class Maintenance_visitService : SubServiceBase<ERPMaintenance_visit>
    {
        public Maintenance_visitService(ERPNextClient client)
            : base(DocType.Maintenance_visit, client) { }

        protected override ERPMaintenance_visit fromERPObject(ERPObject obj)
        {
            return new ERPMaintenance_visit(obj);
        }
    }
}