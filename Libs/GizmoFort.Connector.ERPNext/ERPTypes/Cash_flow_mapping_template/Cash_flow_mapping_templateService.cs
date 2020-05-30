using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapping_template
{
    public class Cash_flow_mapping_templateService : SubServiceBase<ERPCash_flow_mapping_template>
    {
        public Cash_flow_mapping_templateService(ERPNextClient client)
            : base(DocType.Cash_flow_mapping_template, client) { }

        protected override ERPCash_flow_mapping_template fromERPObject(ERPObject obj)
        {
            return new ERPCash_flow_mapping_template(obj);
        }
    }
}