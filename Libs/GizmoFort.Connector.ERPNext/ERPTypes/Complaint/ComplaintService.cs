using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Complaint
{
    public class ComplaintService : SubServiceBase<ERPComplaint>
    {
        public ComplaintService(ERPNextClient client)
            : base(DocType.Complaint, client) { }

        protected override ERPComplaint fromERPObject(ERPObject obj)
        {
            return new ERPComplaint(obj);
        }
    }
}