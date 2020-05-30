using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Prescription_duration
{
    public class Prescription_durationService : SubServiceBase<ERPPrescription_duration>
    {
        public Prescription_durationService(ERPNextClient client)
            : base(DocType.Prescription_duration, client) { }

        protected override ERPPrescription_duration fromERPObject(ERPObject obj)
        {
            return new ERPPrescription_duration(obj);
        }
    }
}