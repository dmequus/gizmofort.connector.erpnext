using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_component_account
{
    public class Salary_component_accountService : SubServiceBase<ERPSalary_component_account>
    {
        public Salary_component_accountService(ERPNextClient client)
            : base(DocType.Salary_component_account, client) { }

        protected override ERPSalary_component_account fromERPObject(ERPObject obj)
        {
            return new ERPSalary_component_account(obj);
        }
    }
}