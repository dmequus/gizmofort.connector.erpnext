using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Customer_credit_limit
{
    public class Customer_credit_limitService : SubServiceBase<ERPCustomer_credit_limit>
    {
        public Customer_credit_limitService(ERPNextClient client)
            : base(DocType.Customer_credit_limit, client) { }

        protected override ERPCustomer_credit_limit fromERPObject(ERPObject obj)
        {
            return new ERPCustomer_credit_limit(obj);
        }
    }
}