using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_onboarding_activity
{
    public class Employee_onboarding_activityService : SubServiceBase<ERPEmployee_onboarding_activity>
    {
        public Employee_onboarding_activityService(ERPNextClient client)
            : base(DocType.Employee_onboarding_activity, client) { }

        protected override ERPEmployee_onboarding_activity fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_onboarding_activity(obj);
        }
    }
}