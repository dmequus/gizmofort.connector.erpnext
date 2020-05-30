using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Compensatory_leave_request
{
    public class Compensatory_leave_requestService : SubServiceBase<ERPCompensatory_leave_request>
    {
        public Compensatory_leave_requestService(ERPNextClient client)
            : base(DocType.Compensatory_leave_request, client) { }

        protected override ERPCompensatory_leave_request fromERPObject(ERPObject obj)
        {
            return new ERPCompensatory_leave_request(obj);
        }
    }
}