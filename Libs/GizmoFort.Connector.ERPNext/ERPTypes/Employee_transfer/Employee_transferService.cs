using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_transfer
{
    public class Employee_transferService : SubServiceBase<ERPEmployee_transfer>
    {
        public Employee_transferService(ERPNextClient client)
            : base(DocType.Employee_transfer, client) { }

        protected override ERPEmployee_transfer fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_transfer(obj);
        }
    }
}