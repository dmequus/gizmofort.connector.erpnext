using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapping_template_details
{
    public class Cash_flow_mapping_template_detailsService : SubServiceBase<ERPCash_flow_mapping_template_details>
    {
        public Cash_flow_mapping_template_detailsService(ERPNextClient client)
            : base(DocType.Cash_flow_mapping_template_details, client) { }

        protected override ERPCash_flow_mapping_template_details fromERPObject(ERPObject obj)
        {
            return new ERPCash_flow_mapping_template_details(obj);
        }
    }
}