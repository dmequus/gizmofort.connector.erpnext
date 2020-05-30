using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_security_price
{
    public class Loan_security_priceService : SubServiceBase<ERPLoan_security_price>
    {
        public Loan_security_priceService(ERPNextClient client)
            : base(DocType.Loan_security_price, client) { }

        protected override ERPLoan_security_price fromERPObject(ERPObject obj)
        {
            return new ERPLoan_security_price(obj);
        }
    }
}