using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Shift_request
{
    public class Shift_requestService : SubServiceBase<ERPShift_request>
    {
        public Shift_requestService(ERPNextClient client)
            : base(DocType.Shift_request, client) { }

        protected override ERPShift_request fromERPObject(ERPObject obj)
        {
            return new ERPShift_request(obj);
        }
    }
}