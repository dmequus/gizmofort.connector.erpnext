using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_advance
{
    public class Employee_advanceService : SubServiceBase<ERPEmployee_advance>
    {
        public Employee_advanceService(ERPNextClient client)
            : base(DocType.Employee_advance, client) { }

        protected override ERPEmployee_advance fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_advance(obj);
        }
    }
}