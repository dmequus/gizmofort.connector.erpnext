using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_visit_purpose
{
    public class Maintenance_visit_purposeService : SubServiceBase<ERPMaintenance_visit_purpose>
    {
        public Maintenance_visit_purposeService(ERPNextClient client)
            : base(DocType.Maintenance_visit_purpose, client) { }

        protected override ERPMaintenance_visit_purpose fromERPObject(ERPObject obj)
        {
            return new ERPMaintenance_visit_purpose(obj);
        }
    }
}