using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Patient_assessment_parameter
{
    public class Patient_assessment_parameterService : SubServiceBase<ERPPatient_assessment_parameter>
    {
        public Patient_assessment_parameterService(ERPNextClient client)
            : base(DocType.Patient_assessment_parameter, client) { }

        protected override ERPPatient_assessment_parameter fromERPObject(ERPObject obj)
        {
            return new ERPPatient_assessment_parameter(obj);
        }
    }
}