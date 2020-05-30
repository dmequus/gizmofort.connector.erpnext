using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Procedure_prescription
{
    public class Procedure_prescriptionService : SubServiceBase<ERPProcedure_prescription>
    {
        public Procedure_prescriptionService(ERPNextClient client)
            : base(DocType.Procedure_prescription, client) { }

        protected override ERPProcedure_prescription fromERPObject(ERPObject obj)
        {
            return new ERPProcedure_prescription(obj);
        }
    }
}