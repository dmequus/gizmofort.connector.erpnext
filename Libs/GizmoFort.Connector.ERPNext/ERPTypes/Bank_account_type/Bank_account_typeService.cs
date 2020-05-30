using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_account_type
{
    public class Bank_account_typeService : SubServiceBase<ERPBank_account_type>
    {
        public Bank_account_typeService(ERPNextClient client)
            : base(DocType.Bank_account_type, client) { }

        protected override ERPBank_account_type fromERPObject(ERPObject obj)
        {
            return new ERPBank_account_type(obj);
        }
    }
}