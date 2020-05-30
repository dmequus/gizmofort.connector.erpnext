using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_proof_submission_detail
{
    public class Employee_tax_exemption_proof_submission_detailService : SubServiceBase<ERPEmployee_tax_exemption_proof_submission_detail>
    {
        public Employee_tax_exemption_proof_submission_detailService(ERPNextClient client)
            : base(DocType.Employee_tax_exemption_proof_submission_detail, client) { }

        protected override ERPEmployee_tax_exemption_proof_submission_detail fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_tax_exemption_proof_submission_detail(obj);
        }
    }
}