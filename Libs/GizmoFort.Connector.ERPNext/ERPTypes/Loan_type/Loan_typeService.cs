using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_type
{
    public class Loan_typeService : SubServiceBase<ERPLoan_type>
    {
        public Loan_typeService(ERPNextClient client)
            : base(DocType.Loan_type, client) { }

        protected override ERPLoan_type fromERPObject(ERPObject obj)
        {
            return new ERPLoan_type(obj);
        }
    }
}