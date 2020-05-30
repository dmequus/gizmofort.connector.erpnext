using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Account
{
    public class AccountService : SubServiceBase<ERPAccount>
    {
        public AccountService(ERPNextClient client)
            : base(DocType.Account, client) { }

        protected override ERPAccount fromERPObject(ERPObject obj)
        {
            return new ERPAccount(obj);
        }
    }
}