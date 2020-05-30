using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Customer_group
{
    public class Customer_groupService : SubServiceBase<ERPCustomer_group>
    {
        public Customer_groupService(ERPNextClient client)
            : base(DocType.Customer_group, client) { }

        protected override ERPCustomer_group fromERPObject(ERPObject obj)
        {
            return new ERPCustomer_group(obj);
        }
    }
}