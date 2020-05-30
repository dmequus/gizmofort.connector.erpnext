using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Request_for_quotation
{
    public class Request_for_quotationService : SubServiceBase<ERPRequest_for_quotation>
    {
        public Request_for_quotationService(ERPNextClient client)
            : base(DocType.Request_for_quotation, client) { }

        protected override ERPRequest_for_quotation fromERPObject(ERPObject obj)
        {
            return new ERPRequest_for_quotation(obj);
        }
    }
}