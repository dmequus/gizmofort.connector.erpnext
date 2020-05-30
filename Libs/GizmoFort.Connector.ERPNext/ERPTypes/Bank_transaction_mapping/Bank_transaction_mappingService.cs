using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_transaction_mapping
{
    public class Bank_transaction_mappingService : SubServiceBase<ERPBank_transaction_mapping>
    {
        public Bank_transaction_mappingService(ERPNextClient client)
            : base(DocType.Bank_transaction_mapping, client) { }

        protected override ERPBank_transaction_mapping fromERPObject(ERPObject obj)
        {
            return new ERPBank_transaction_mapping(obj);
        }
    }
}