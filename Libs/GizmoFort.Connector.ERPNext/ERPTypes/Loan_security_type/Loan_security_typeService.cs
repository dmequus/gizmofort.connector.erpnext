using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_security_type
{
    public class Loan_security_typeService : SubServiceBase<ERPLoan_security_type>
    {
        public Loan_security_typeService(ERPNextClient client)
            : base(DocType.Loan_security_type, client) { }

        protected override ERPLoan_security_type fromERPObject(ERPObject obj)
        {
            return new ERPLoan_security_type(obj);
        }
    }
}