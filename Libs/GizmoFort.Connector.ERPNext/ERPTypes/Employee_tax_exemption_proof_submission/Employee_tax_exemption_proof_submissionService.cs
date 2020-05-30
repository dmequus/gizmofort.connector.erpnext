using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_proof_submission
{
    public class Employee_tax_exemption_proof_submissionService : SubServiceBase<ERPEmployee_tax_exemption_proof_submission>
    {
        public Employee_tax_exemption_proof_submissionService(ERPNextClient client)
            : base(DocType.Employee_tax_exemption_proof_submission, client) { }

        protected override ERPEmployee_tax_exemption_proof_submission fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_tax_exemption_proof_submission(obj);
        }
    }
}