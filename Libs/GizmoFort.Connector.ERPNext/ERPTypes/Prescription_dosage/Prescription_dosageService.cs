using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Prescription_dosage
{
    public class Prescription_dosageService : SubServiceBase<ERPPrescription_dosage>
    {
        public Prescription_dosageService(ERPNextClient client)
            : base(DocType.Prescription_dosage, client) { }

        protected override ERPPrescription_dosage fromERPObject(ERPObject obj)
        {
            return new ERPPrescription_dosage(obj);
        }
    }
}