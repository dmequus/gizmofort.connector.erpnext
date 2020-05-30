using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Salary_component
{
    public class Salary_componentService : SubServiceBase<ERPSalary_component>
    {
        public Salary_componentService(ERPNextClient client)
            : base(DocType.Salary_component, client) { }

        protected override ERPSalary_component fromERPObject(ERPObject obj)
        {
            return new ERPSalary_component(obj);
        }
    }
}