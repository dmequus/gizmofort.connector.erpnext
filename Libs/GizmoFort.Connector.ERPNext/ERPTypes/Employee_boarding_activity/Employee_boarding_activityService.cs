using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_boarding_activity
{
    public class Employee_boarding_activityService : SubServiceBase<ERPEmployee_boarding_activity>
    {
        public Employee_boarding_activityService(ERPNextClient client)
            : base(DocType.Employee_boarding_activity, client) { }

        protected override ERPEmployee_boarding_activity fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_boarding_activity(obj);
        }
    }
}