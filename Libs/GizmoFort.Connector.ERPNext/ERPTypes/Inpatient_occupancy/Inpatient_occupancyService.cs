using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Inpatient_occupancy
{
    public class Inpatient_occupancyService : SubServiceBase<ERPInpatient_occupancy>
    {
        public Inpatient_occupancyService(ERPNextClient client)
            : base(DocType.Inpatient_occupancy, client) { }

        protected override ERPInpatient_occupancy fromERPObject(ERPObject obj)
        {
            return new ERPInpatient_occupancy(obj);
        }
    }
}