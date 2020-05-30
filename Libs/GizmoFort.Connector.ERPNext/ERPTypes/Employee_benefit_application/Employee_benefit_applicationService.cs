using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_benefit_application
{
    public class Employee_benefit_applicationService : SubServiceBase<ERPEmployee_benefit_application>
    {
        public Employee_benefit_applicationService(ERPNextClient client)
            : base(DocType.Employee_benefit_application, client) { }

        protected override ERPEmployee_benefit_application fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_benefit_application(obj);
        }
    }
}