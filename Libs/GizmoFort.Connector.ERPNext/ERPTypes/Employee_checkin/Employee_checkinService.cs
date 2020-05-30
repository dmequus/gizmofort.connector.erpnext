using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_checkin
{
    public class Employee_checkinService : SubServiceBase<ERPEmployee_checkin>
    {
        public Employee_checkinService(ERPNextClient client)
            : base(DocType.Employee_checkin, client) { }

        protected override ERPEmployee_checkin fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_checkin(obj);
        }
    }
}