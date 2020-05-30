using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Rename_tool
{
    public class Rename_toolService : SubServiceBase<ERPRename_tool>
    {
        public Rename_toolService(ERPNextClient client)
            : base(DocType.Rename_tool, client) { }

        protected override ERPRename_tool fromERPObject(ERPObject obj)
        {
            return new ERPRename_tool(obj);
        }
    }
}