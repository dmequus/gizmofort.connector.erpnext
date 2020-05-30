using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_health_insurance
{
    public class Employee_health_insuranceService : SubServiceBase<ERPEmployee_health_insurance>
    {
        public Employee_health_insuranceService(ERPNextClient client)
            : base(DocType.Employee_health_insurance, client) { }

        protected override ERPEmployee_health_insurance fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_health_insurance(obj);
        }
    }
}