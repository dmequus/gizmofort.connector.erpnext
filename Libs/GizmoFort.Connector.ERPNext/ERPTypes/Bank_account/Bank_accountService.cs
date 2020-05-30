using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_account
{
    public class Bank_accountService : SubServiceBase<ERPBank_account>
    {
        public Bank_accountService(ERPNextClient client)
            : base(DocType.Bank_account, client) { }

        protected override ERPBank_account fromERPObject(ERPObject obj)
        {
            return new ERPBank_account(obj);
        }
    }
}