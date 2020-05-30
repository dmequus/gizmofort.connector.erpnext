using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_assessment_sheet
{
    public class Patient_assessment_sheetService : SubServiceBase<ERPPatient_assessment_sheet>
    {
        public Patient_assessment_sheetService(ERPNextClient client)
            : base(DocType.Patient_assessment_sheet, client) { }

        protected override ERPPatient_assessment_sheet fromERPObject(ERPObject obj)
        {
            return new ERPPatient_assessment_sheet(obj);
        }
    }
}