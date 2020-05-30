using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Lab_prescription
{
    public class Lab_prescriptionService : SubServiceBase<ERPLab_prescription>
    {
        public Lab_prescriptionService(ERPNextClient client)
            : base(DocType.Lab_prescription, client) { }

        protected override ERPLab_prescription fromERPObject(ERPObject obj)
        {
            return new ERPLab_prescription(obj);
        }
    }
}