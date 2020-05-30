using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Drug_prescription
{
    public class Drug_prescriptionService : SubServiceBase<ERPDrug_prescription>
    {
        public Drug_prescriptionService(ERPNextClient client)
            : base(DocType.Drug_prescription, client) { }

        protected override ERPDrug_prescription fromERPObject(ERPObject obj)
        {
            return new ERPDrug_prescription(obj);
        }
    }
}