using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Tax_withholding_account
{
    public class Tax_withholding_accountService : SubServiceBase<ERPTax_withholding_account>
    {
        public Tax_withholding_accountService(ERPNextClient client)
            : base(DocType.Tax_withholding_account, client) { }

        protected override ERPTax_withholding_account fromERPObject(ERPObject obj)
        {
            return new ERPTax_withholding_account(obj);
        }
    }
}