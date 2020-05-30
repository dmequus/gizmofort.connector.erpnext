using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Request_for_quotation_supplier
{
    public class Request_for_quotation_supplierService : SubServiceBase<ERPRequest_for_quotation_supplier>
    {
        public Request_for_quotation_supplierService(ERPNextClient client)
            : base(DocType.Request_for_quotation_supplier, client) { }

        protected override ERPRequest_for_quotation_supplier fromERPObject(ERPObject obj)
        {
            return new ERPRequest_for_quotation_supplier(obj);
        }
    }
}