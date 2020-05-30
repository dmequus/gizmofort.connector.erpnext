using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_onboarding_template
{
    public class Employee_onboarding_templateService : SubServiceBase<ERPEmployee_onboarding_template>
    {
        public Employee_onboarding_templateService(ERPNextClient client)
            : base(DocType.Employee_onboarding_template, client) { }

        protected override ERPEmployee_onboarding_template fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_onboarding_template(obj);
        }
    }
}