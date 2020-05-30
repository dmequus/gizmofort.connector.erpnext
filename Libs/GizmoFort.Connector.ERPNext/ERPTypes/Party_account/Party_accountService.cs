using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Party_account
{
    public class Party_accountService : SubServiceBase<ERPParty_account>
    {
        public Party_accountService(ERPNextClient client)
            : base(DocType.Party_account, client) { }

        protected override ERPParty_account fromERPObject(ERPObject obj)
        {
            return new ERPParty_account(obj);
        }
    }
}