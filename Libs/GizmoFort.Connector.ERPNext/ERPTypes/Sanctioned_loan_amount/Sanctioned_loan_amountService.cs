using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Sanctioned_loan_amount
{
    public class Sanctioned_loan_amountService : SubServiceBase<ERPSanctioned_loan_amount>
    {
        public Sanctioned_loan_amountService(ERPNextClient client)
            : base(DocType.Sanctioned_loan_amount, client) { }

        protected override ERPSanctioned_loan_amount fromERPObject(ERPObject obj)
        {
            return new ERPSanctioned_loan_amount(obj);
        }
    }
}