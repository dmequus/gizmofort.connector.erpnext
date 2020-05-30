using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_onboarding
{
    public class Employee_onboardingService : SubServiceBase<ERPEmployee_onboarding>
    {
        public Employee_onboardingService(ERPNextClient client)
            : base(DocType.Employee_onboarding, client) { }

        protected override ERPEmployee_onboarding fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_onboarding(obj);
        }
    }
}