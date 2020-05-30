using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_incentive
{
    public class Employee_incentiveService : SubServiceBase<ERPEmployee_incentive>
    {
        public Employee_incentiveService(ERPNextClient client)
            : base(DocType.Employee_incentive, client) { }

        protected override ERPEmployee_incentive fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_incentive(obj);
        }
    }
}