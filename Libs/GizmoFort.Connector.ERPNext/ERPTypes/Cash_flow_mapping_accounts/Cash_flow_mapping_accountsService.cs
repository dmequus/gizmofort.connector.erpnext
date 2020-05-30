using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapping_accounts
{
    public class Cash_flow_mapping_accountsService : SubServiceBase<ERPCash_flow_mapping_accounts>
    {
        public Cash_flow_mapping_accountsService(ERPNextClient client)
            : base(DocType.Cash_flow_mapping_accounts, client) { }

        protected override ERPCash_flow_mapping_accounts fromERPObject(ERPObject obj)
        {
            return new ERPCash_flow_mapping_accounts(obj);
        }
    }
}