using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_account_subtype
{
    public class Bank_account_subtypeService : SubServiceBase<ERPBank_account_subtype>
    {
        public Bank_account_subtypeService(ERPNextClient client)
            : base(DocType.Bank_account_subtype, client) { }

        protected override ERPBank_account_subtype fromERPObject(ERPObject obj)
        {
            return new ERPBank_account_subtype(obj);
        }
    }
}