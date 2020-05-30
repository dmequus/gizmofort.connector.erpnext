using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_benefit_claim
{
    public class Employee_benefit_claimService : SubServiceBase<ERPEmployee_benefit_claim>
    {
        public Employee_benefit_claimService(ERPNextClient client)
            : base(DocType.Employee_benefit_claim, client) { }

        protected override ERPEmployee_benefit_claim fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_benefit_claim(obj);
        }
    }
}