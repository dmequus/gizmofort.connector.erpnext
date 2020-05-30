using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapping
{
    public class Cash_flow_mappingService : SubServiceBase<ERPCash_flow_mapping>
    {
        public Cash_flow_mappingService(ERPNextClient client)
            : base(DocType.Cash_flow_mapping, client) { }

        protected override ERPCash_flow_mapping fromERPObject(ERPObject obj)
        {
            return new ERPCash_flow_mapping(obj);
        }
    }
}