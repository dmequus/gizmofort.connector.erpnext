using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Request_for_quotation_item
{
    public class Request_for_quotation_itemService : SubServiceBase<ERPRequest_for_quotation_item>
    {
        public Request_for_quotation_itemService(ERPNextClient client)
            : base(DocType.Request_for_quotation_item, client) { }

        protected override ERPRequest_for_quotation_item fromERPObject(ERPObject obj)
        {
            return new ERPRequest_for_quotation_item(obj);
        }
    }
}