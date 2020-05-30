using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bom_update_tool
{
    public class Bom_update_toolService : SubServiceBase<ERPBom_update_tool>
    {
        public Bom_update_toolService(ERPNextClient client)
            : base(DocType.Bom_update_tool, client) { }

        protected override ERPBom_update_tool fromERPObject(ERPObject obj)
        {
            return new ERPBom_update_tool(obj);
        }
    }
}