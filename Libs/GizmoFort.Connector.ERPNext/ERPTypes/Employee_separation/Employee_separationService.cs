using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_separation
{
    public class Employee_separationService : SubServiceBase<ERPEmployee_separation>
    {
        public Employee_separationService(ERPNextClient client)
            : base(DocType.Employee_separation, client) { }

        protected override ERPEmployee_separation fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_separation(obj);
        }
    }
}