using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Loan_application
{
    public class Loan_applicationService : SubServiceBase<ERPLoan_application>
    {
        public Loan_applicationService(ERPNextClient client)
            : base(DocType.Loan_application, client) { }

        protected override ERPLoan_application fromERPObject(ERPObject obj)
        {
            return new ERPLoan_application(obj);
        }
    }
}