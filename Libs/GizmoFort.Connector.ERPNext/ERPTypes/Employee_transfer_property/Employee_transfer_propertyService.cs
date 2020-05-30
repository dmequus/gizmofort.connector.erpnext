using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_transfer_property
{
    public class Employee_transfer_propertyService : SubServiceBase<ERPEmployee_transfer_property>
    {
        public Employee_transfer_propertyService(ERPNextClient client)
            : base(DocType.Employee_transfer_property, client) { }

        protected override ERPEmployee_transfer_property fromERPObject(ERPObject obj)
        {
            return new ERPEmployee_transfer_property(obj);
        }
    }
}